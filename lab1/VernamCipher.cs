using System;
using System.Text;

namespace lab1
{
    public static class VernamCipher
    {
        private static readonly char[] ALPHABET = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ" + 
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" + 
            "abcdefghijklmnopqrstuvwxyz" + 
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя").ToCharArray();

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

        public static string Encrypt(string text, string keyseq)
        {
            StringBuilder sb = new StringBuilder(text.Length);

            byte textByte;
            byte keyseqByte;
            char ch;
            for (int i = 0; i < text.Length; i++)
            {
                textByte = (byte)text[i];
                keyseqByte = (byte)keyseq[i];

                ch = (char)(byte)(textByte ^ keyseqByte);
                sb.Append(ch);
            }

            return sb.ToString();
        }

        public static string Decrypt(string encryptedText, string keyseq)
        {
            StringBuilder sb = new StringBuilder(encryptedText.Length);

            byte encodedTextByte;
            byte keyseqByte;
            char ch;
            for (int i = 0; i < encryptedText.Length; i++)
            {
                encodedTextByte = (byte)encryptedText[i];
                keyseqByte = (byte)keyseq[i];

                ch = (char)(byte)(encodedTextByte ^ keyseqByte);
                sb.Append(ch);
            }

            return sb.ToString();
        }
    }
}
