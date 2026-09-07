namespace Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[101];
            fillNumArray(numArray);

            bool[] A = new bool[numArray.Length];
            fillBoolA(A);

            for (int i = 2; i <= Math.Sqrt(numArray.Length); i++)
            {
                if (A[i] == true)
                {
                    for (int j = i + i; j < numArray.Length; j += i)
                    {
                        A[j] = false;
                    }
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == true)
                {
                    Console.WriteLine("Kolejna liczba pierwsza: " + i);
                }
            }
        }

        static void fillNumArray(int[] array)
        {
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = i;
            }
        }

        static void fillBoolA(bool[] A)
        {
            for (int i = 2; i < A.Length; i++)
            {
                A[i] = true;
            }
        }
    }
}