using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class VernamCipher
    {
        public static string GenerateKeyseq(int textLen)
        {
            StringBuilder sb = new StringBuilder(textLen);

            Random random = new Random();
            char ch;
            for (int i = 0; i < textLen; i++)
            {
                ch = (char)random.Next(256);
                sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
