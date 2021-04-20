namespace Rsa
{
    public class Rsa
    {
        public static readonly char[] ALPHABET = new char[] {
            '#', 'А', 'Б', 'В', 'Г',
            'Д', 'Е', 'Ё', 'Ж', 'З',
            'И', 'Й', 'К', 'Л', 'М',
            'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц',
            'Ч', 'Ш', 'Щ', 'Ь', 'Ы',
            'Ъ', 'Э', 'Ю', 'Я', ' ',
            '1', '2', '3', '4', '5',
            '6', '7', '8', '9', '0' };

        public static bool IsPrime(long num)
        {
            for (long i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;

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

}
