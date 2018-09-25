using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginForm.Database
{
    class validaciones
    {
        public static bool claveEsValida(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                //ErrorMessage = "Password should contain At least one lower case letter";
                ErrorMessage = "La contraseña debe contener al menos una letra minúscula.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                //ErrorMessage = "Password should contain At least one upper case letter";
                ErrorMessage = "La contraseña debe contener al menos una letra mayúscula.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                //ErrorMessage = "Password should not be less than or greater than 12 characters";
                ErrorMessage = "La contraseña debe contener al menos 8 caracteres";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                //ErrorMessage = "Password should contain At least one numeric value";
                ErrorMessage = "La contraseña debe contener al menos un número.";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                //ErrorMessage = "Password should contain At least one special case characters";
                ErrorMessage = "La contraseña debe contener al menos un carácter especial.";
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool emailEsValido(string email, out string errorMessage)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                errorMessage = "El correo electronico no es valido.";
                return false;
            }
        }
    }
}
