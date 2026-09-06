namespace Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a, b;

            Console.WriteLine("Podaj a:");
            a = uint.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b:");
            b = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nNWD:");
            Console.WriteLine(Euclides(a, b));
        }

        public static uint Euclides(uint a, uint b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
