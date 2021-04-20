﻿using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rsa
{
    public static class RsaText
    {
        public static readonly string INPUT_PATH = "in.txt";
        public static readonly string ENCRYPTED_PATH = "out-encrypted.txt";

        public static void Encode(long p, long q)
        {
            string text = File.ReadAllText(INPUT_PATH, Encoding.UTF8);

            List<string> encryptedList = Rsa.Encode(text, p, q);

            using (StreamWriter writer = new StreamWriter(ENCRYPTED_PATH))
            {
                foreach (string line in encryptedList)
                    writer.WriteLine(line);
            }
        }
    }
}