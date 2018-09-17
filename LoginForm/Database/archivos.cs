using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace LoginForm.Database
{
    class DBfunciones
    {
        public static string urlImagenPerfil(int idUsuario)
        {
            MySqlCommand command = new MySqlCommand("SELECT imagenperfil from usuario WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            DataTable datos = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(datos);
            string urlImagenPerfil = Convert.ToString(datos.Rows[0].ItemArray[0]);
            if (string.IsNullOrEmpty(urlImagenPerfil))
            {
                urlImagenPerfil = "default.jpg";
            }
            urlImagenPerfil = "https://pluzedu.com/profile/" + urlImagenPerfil;
            return urlImagenPerfil;
        }
        public static bool guardarImagenPerfil(int idUsuario, string urlImagen)
        {
            MySqlCommand command = new MySqlCommand("UPDATE usuario SET imagenperfil=@urlImagen WHERE id=@idUsuario", conexion.obtenerconexion());
            command.Parameters.Add("@urlImagen", MySqlDbType.VarChar).Value = urlImagen;
            command.Parameters.Add("@idUsuario", MySqlDbType.Int32).Value = idUsuario;
            return Convert.ToBoolean(command.ExecuteNonQuery());
        }
    }
    class archivos
    {
        public static async Task<Image> recibirImg(string url)
        {
            var tcs = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith(task =>
                {
                    var webResponse = (HttpWebResponse)task.Result;
                    Stream responseStream = webResponse.GetResponseStream();
                    if (webResponse.ContentEncoding.ToLower().Contains("gzip"))
                        responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                    else if (webResponse.ContentEncoding.ToLower().Contains("deflate"))
                        responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

                    if (responseStream != null) webImage = Image.FromStream(responseStream);
                    tcs.TrySetResult(webImage);
                    webResponse.Close();
                    responseStream.Close();
                });
            return tcs.Task.Result;
        }

        public static void subirImagen(Stream imgStream, int idUsuario)
        {
            var host = "pluzedu.com";
            var port = 22;
            var username = "files";
            var password = "pluzedu_)(*&^%$#@!@#$%^&*()_";
            string nombreImg = nombreImgAleatorio();
            using (var client = new SftpClient(host, port, username, password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    client.BufferSize = 4 * 1024; // bypass Payload error large files
                    if (!existeDirectorio("/var/www/html/profile/" + idUsuario))
                    {
                        client.CreateDirectory("/var/www/html/profile/" + idUsuario);
                    }
                    //client.UploadFile(fileStream, "/var/www/html/profile/" + idusuario + "/" + Path.GetFileName(uploadFile), null);
                    imgStream.Position = 0;
                    string urlFinal = idUsuario + "/" + nombreImg;
                    client.UploadFile(imgStream, "/var/www/html/profile/" + urlFinal, null);
                    client.Disconnect();
                    DBfunciones.guardarImagenPerfil(idUsuario, urlFinal);
                }
                else
                {
                    MessageBox.Show("No se puede acceder al servidor, asegurate que estas conectado a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void subirArchivo(string filePath, int idConversacion, int idAutor)
        {
            var host = "pluzedu.com";
            var port = 22;
            var username = "files";
            var password = "pluzedu_)(*&^%$#@!@#$%^&*()_";

            // path for file you want to upload
            var uploadFile = @filePath;

            using (var client = new SftpClient(host, port, username, password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    using (var fileStream = new FileStream(uploadFile, FileMode.Open))
                    {

                        if (!existeDirectorio("/var/www/html/files/" + idConversacion))
                        {
                            client.CreateDirectory("/var/www/html/files/" + idConversacion);
                        }
                        string urlFinal = idConversacion + "/" + nombreAleatorioArchivo(Path.GetFileName(uploadFile));
                        client.UploadFile(fileStream, "/var/www/html/files/" + urlFinal, null);
                        client.Disconnect();
                        Database.funcionesCRUD.enviarArchivo(idConversacion, urlFinal, idAutor);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede acceder al servidor, asegurate que estas conectado a Internet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string nombreImgAleatorio()
        {
            Random rnd = new Random();
            string[] stringArray = new string[12];
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = rnd.Next(0, 10).ToString();
            }
            string nombreImgAleatorio = (string.Join("", stringArray)) + ".jpg";
            return nombreImgAleatorio;
        }

        public static string nombreAleatorioArchivo(string nombreOriginal)
        {
            Random rnd = new Random();
            string[] stringArray = new string[5];
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = rnd.Next(0, 10).ToString();
            }
            string numAleatorios = string.Join("", stringArray);
            return numAleatorios + "_" + Uri.EscapeUriString(nombreOriginal);
        }
        public static string nombreOriginalArchivo(string urlArchivo)
        {
            return Uri.UnescapeDataString(Regex.Match(urlArchivo, @"_(.*)").Groups[1].Value);
        }

        private static bool existeDirectorio(string path)
        {
            bool existeDirectorio = false;
            var host = "pluzedu.com";
            var port = 22;
            var username = "files";
            var password = "pluzedu_)(*&^%$#@!@#$%^&*()_";
            using (var client = new SftpClient(host, port, username, password))
            {
                client.Connect();
                if (client.IsConnected)
                {
                    try
                    {

                        client.ChangeDirectory(path);
                        existeDirectorio = true;
                    }
                    catch (SftpPathNotFoundException)
                    {
                        return false;
                    }
                    client.ChangeDirectory("/var/www/html/");
                    client.Disconnect();
                }
                return existeDirectorio;
            }
        }
    }
    class ImageResize
    {
        public enum Dimensions
        {
            Width,
            Height
        }
        public enum AnchorPosition
        {
            Top,
            Center,
            Bottom,
            Left,
            Right
        }
        [STAThread]
        public static Stream Crop(Image imgPhoto, int Width, int Height, AnchorPosition Anchor)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                switch (Anchor)
                {
                    case AnchorPosition.Top:
                        destY = 0;
                        break;
                    case AnchorPosition.Bottom:
                        destY = (int)(Height - (sourceHeight * nPercent));
                        break;
                    default:
                        destY = (int)((Height - (sourceHeight * nPercent)) / 2);
                        break;
                }
            }
            else
            {
                nPercent = nPercentH;
                switch (Anchor)
                {
                    case AnchorPosition.Left:
                        destX = 0;
                        break;
                    case AnchorPosition.Right:
                        destX = (int)(Width - (sourceWidth * nPercent));
                        break;
                    default:
                        destX = (int)((Width - (sourceWidth * nPercent)) / 2);
                        break;
                }
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.Clear(Color.White);

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo ici = null;

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == "image/jpeg")
                    ici = codec;
            }

            EncoderParameters ep = new EncoderParameters();
            ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)50);
            var ms = new MemoryStream();
            bmPhoto.Save(ms, ici, ep);
            ms.Position = 0;
            return ms;
        }
    }
}