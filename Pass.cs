using System;
using System.Linq;

namespace DBaInstaller
{
    internal class Pass
    {
        public static Random rnd = new Random();
        public static string GeneratePass()
        {
            const string PossibleChar = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHUJKLMNOPQRSTUVWXYZ ~`@#$%^&*()_+-=[]{};'\\:\"|,./<>?";
            int size = PossibleChar.Length;
            string pass = "";
            for (int i = 0; i < rnd.Next(14, 18); i++)
            {
                int thisNum = rnd.Next(0, size - 1);
                char p = PossibleChar[thisNum];
                pass += p;
            }
            if (CheckPass(pass)) return pass;
            else return GeneratePass();
        }

        public static bool CheckPass(string pass)
        {

            const string numbers = "0123456789";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string uppercase = "ABCDEFGHUJKLMNOPQRSTUVWXYZ";
            const string symbols = " ~`@#$%^&*()_+-=[]{};'\\:\"|,./<>? ";
            const string russ = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            if (pass.Length < 14 || pass.Length > 18) return false;
            string[] checks = { numbers, lowercase, uppercase, symbols };

            for (int i = 0; i < checks.Length; i++)
            {
                int contain = 0;
                for (int j = 0; j < checks[i].Length; j++)
                {
                    if (pass.Contains(checks[i][j]))
                        contain++;
                }
                if (contain < 2) return false;
            }

            for (int i = 0; i < russ.Length; i++)
            {
                if (pass.Contains(russ[i])) return false;
            }

            return true;
        }

    }
}
