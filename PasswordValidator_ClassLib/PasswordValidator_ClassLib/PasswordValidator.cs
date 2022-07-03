using System;
using System.Linq;

namespace PasswordValidator_ClassLib
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;
            if (!password.Any(Char.IsLower))
                return false;
            if (!password.Any(Char.IsUpper))
            {
                return false;
            }
            if (!password.Any(Char.IsDigit))
            {
                return false;
            }
            if (password.Intersect("#$%^&_").Count() == 0)
            {
                return false;
            }

            return true;
        }
    }
}
