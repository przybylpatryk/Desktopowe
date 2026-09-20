namespace Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PESEL = "55030101193";

            Console.WriteLine("Podaj Pesel: ");
            PESEL = Console.ReadLine();

            Console.WriteLine(checkGender(PESEL) == 'K' ? "Kobieta" : "Mężczyzna");
            Console.WriteLine(checkSum(PESEL)? "Pesel jest poprawny" : "Pesel jest niepoprawny");
        }

        static char checkGender(string PESEL)
        {
            int genderDigit = int.Parse(PESEL[9].ToString());
            if (genderDigit % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        static bool checkSum(string PESEL)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            
            int R, M, S = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                S += weights[i] * int.Parse(PESEL[i].ToString());
            }
            M = S % 10;
            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            return int.Parse(PESEL[10].ToString()) == R;
        }
    }
}
