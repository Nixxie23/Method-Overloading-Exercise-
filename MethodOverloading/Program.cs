using System.Transactions;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        { return x + y; }

        public static decimal Add(decimal x, decimal y)
        { return x + y; }

        public static string Add(int x, int y, bool isTrue)
        {

            if (isTrue == true && x + y == -1)
            {
                return $"{x + y} dollar";
            }
            else if (isTrue == true && x + y == 1)
            {
                return $"{x + y} dollar";
            }
            else if (isTrue == true && x + y > 1 || x + y <= 0)
            {
                return $"{x + y} dollars";
            }
            else
                return "";

}
        static void Main(string[] args)
        {
            Console.WriteLine($"{Add(1, 2)}");
            Console.WriteLine($"{Add(1.3m, 2.5m)}");
            Console.WriteLine($"{Add(1, 2, true)}");
            Console.WriteLine($"{Add(1, 0, true)}");
            Console.WriteLine($"{Add(1, -5, true)}");
            Console.WriteLine($"{Add(1, -2, true)}");
            Console.WriteLine($"{Add(1, 2, false)}");
        }
    }
}
