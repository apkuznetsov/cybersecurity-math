using System.IO;
using System.Text;

namespace Rsa
{
    public static class RsaText
    {
        public static readonly string INPUT_PATH = "in.txt";
        public static readonly string ENCRYPTED_PATH = "out-encrypted.txt";

        public static void Encrypt(long p, long q, out long d, out long n)
        {
            string text = File.ReadAllText(INPUT_PATH, Encoding.UTF8);

            string textEncrypted = Rsa.Encrypt(text, p, q, out d, out n);

            using StreamWriter writer = new StreamWriter(ENCRYPTED_PATH);
            writer.Write(textEncrypted);
        }
    }
}
