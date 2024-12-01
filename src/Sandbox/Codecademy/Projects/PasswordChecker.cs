using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codecademy.Projects
{
    public class PasswordChecker
    {
        public static string PasswordScore(string userPassword)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!£$%^&*()-_+=:;@'~|<>,.?#";
            List<string> badPasswords = ["123456", "password", "qwerty"];
            int score = 0;
            string passwordAssessment;

            if (!badPasswords.Contains(userPassword.ToLower()))
            {
                if (userPassword.Length >= minLength)
                {
                    score++;
                }

                if (Tools.Contains(userPassword, uppercase))
                {
                    score++;
                }

                if (Tools.Contains(userPassword, lowercase))
                {
                    score++;
                }

                if (Tools.Contains(userPassword, digits))
                {
                    score++;
                }

                if (Tools.Contains(userPassword, specialChars))
                {
                    score++;
                }
            }


            switch (score)
            {
                case 5:
                case 4:
                    passwordAssessment = "Extremely strong!";
                    break;
                case 3:
                    passwordAssessment = "Strong";
                    break;
                case 2:
                    passwordAssessment = "Medium";
                    break;
                case 1:
                    passwordAssessment = "Weak";
                    break;
                default:
                    passwordAssessment = "Your password doesn't meet the minimum requirement";
                    break;
            }

            return score == 0 ? passwordAssessment : $"Your password score is {score} and your password is {passwordAssessment}";
        }
    }
}
