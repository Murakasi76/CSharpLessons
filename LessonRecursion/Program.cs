using System.Numerics;

namespace LessonRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some number: ");
            string? value = Console.ReadLine();
            
            int.TryParse(value, out int nub);

            Console.WriteLine($"Number after parse: {nub}");

            //BigInteger result = Factorial(5);
            //Console.WriteLine(result);

            //BigInteger num = GetFactorial(5);
            //Console.WriteLine(num);

        }
        static BigInteger Factorial(BigInteger n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }

            BigInteger result = 1;

            for (BigInteger i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static BigInteger GetFibonachi(BigInteger n)
        {
            BigInteger x = 1;
            for (BigInteger i = 0; i < n; i++)
            {

            }
            return x;
        }
    }
}
