using System;
using System.Text;

namespace Vernam
{
    public static class VernamCipher
    {
        private static readonly string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "abcdefghijklmnopqrstuvwxyz" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ";

        private static int Code(char symbol)
        {
            return ALPHABET.IndexOf(symbol);
        }

        public static string GenerateKeyseq(int textLen)
        {
            StringBuilder sb = new StringBuilder(textLen);

            Random random = new Random();
            int len = ALPHABET.Length;
            int idx;
            for (int i = 0; i < textLen; i++)
            {
                idx = random.Next(len);
                sb.Append(ALPHABET[idx]);
            }

            return sb.ToString();
        }

        public static string Encrypt(string text, string keyseq)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            int mod = ALPHABET.Length;
            int idx;
            for (int i = 0; i < text.Length; i++)
            {
                idx = (Code(text[i]) + Code(keyseq[i])) % mod;
                sb.Append(ALPHABET[idx]);
            }

            return sb.ToString();
        }

        public static string Decrypt(string text, string keyseq)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            int mod = ALPHABET.Length;
            int idx;
            for (int i = 0; i < text.Length; i++)
            {
                idx = (Code(text[i]) - Code(keyseq[i])) % mod;
                idx = idx < 0 ? mod + idx : idx % mod;
                sb.Append(ALPHABET[idx]);
            }

            return sb.ToString();
        }
    }
}
