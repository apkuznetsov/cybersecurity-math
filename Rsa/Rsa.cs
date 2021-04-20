using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Rsa
{
    public static class Rsa
    {
        public static readonly char[] ALPHABET = new char[] {
            'А', 'Б', 'В', 'Г', 'Д',
            'Е', 'Ё', 'Ж', 'З', 'И',
            'Й', 'К', 'Л', 'М', 'Н',
            'О', 'П', 'Р', 'С', 'Т',
            'У', 'Ф', 'Х', 'Ц', 'Ч',
            'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
            'Э', 'Ю', 'Я',
            '0', '1', '2', '3', '4',
            '5', '6', '7', '8', '9',
            ' ', '#',
        };

        public static string Encrypt(string text, long p, long q)
        {
            bool arePositive = (p > 0) && (q > 0);
            if (!arePositive)
                throw new NotPositiveException();

            bool arePrime = IsPrime(p) && IsPrime(q);
            if (!arePrime)
                throw new NotPrimeException();

            long n = p * q;
            long euler = (p - 1) * (q - 1);
            long d = D(euler);
            long e = E(d, euler);

            return EncryptWithEn(text, e, n);
        }

        private static bool IsPrime(long num)
        {
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        private static long D(long euler)
        {
            long d = euler - 1;

            bool areCoprime;
            for (long i = 2; i <= d; i++)
            {
                areCoprime = (euler % i == 0) && (d % i == 0);
                if (areCoprime)
                {
                    d--;
                    i = 1;
                }
            }

            return d;
        }

        private static long E(long d, long euler)
        {
            long e = 10;

            bool isRemainderOne;
            while (true)
            {
                isRemainderOne = (e * d) % euler == 1;
                if (isRemainderOne)
                    break;
                else
                    e++;
            }

            return e;
        }

        private static string EncryptWithEn(string text, long e, long n)
        {
            StringBuilder textEncrypted = new StringBuilder();

            int alphabetIdx;
            BigInteger resBi;
            BigInteger eBi = new BigInteger(e);
            BigInteger nBi = new BigInteger(n);
            for (int idx = 0; idx < text.Length; idx++)
            {
                alphabetIdx = Array.IndexOf(ALPHABET, char.ToUpper(text[idx]));

                resBi = BigInteger.ModPow(
                    new BigInteger(alphabetIdx), eBi, nBi);

                textEncrypted.Append(resBi.ToString()).Append(Environment.NewLine);
            }

            return textEncrypted.ToString();
        }

            return result;
        }
    }
}
