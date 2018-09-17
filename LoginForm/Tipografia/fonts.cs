using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Text;

namespace LoginForm.Tipografia
{
    class fonts
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection font = new PrivateFontCollection();

        static Font myFont;

        public static Font getFont(Single size)
        {
            byte[] fontData = Properties.Resources.fa_solid_900;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            font.AddMemoryFont(fontPtr, Properties.Resources.fa_solid_900.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.fa_solid_900.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(font.Families[0], size);
            return myFont;
        }
        public static Font fontawesome60 = getFont(60.0F);
        public static Font fontawesome30 = getFont(30.0F);
        public static Font fontawesome24 = getFont(24.25F);
        public static Font fontawesome20 = getFont(20.25F);
        public static Font fontawesome16 = getFont(15.75F);
        public static Font fontawesome14 = getFont(14.25F);
        public static Font fontawesome12 = getFont(12.0F);
    }
}
