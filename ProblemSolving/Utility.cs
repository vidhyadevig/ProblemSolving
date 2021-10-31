using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class Utility
    {
        static string Generate6digitUniqueCode()
        {
            Random ran = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int UniqueCodeLength = 6;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < UniqueCodeLength; i++)
            {
                int pos = ran.Next(characters.Length);
                result.Append(characters.ElementAt(pos));
            }
            return result.ToString();
        }
    }
}
