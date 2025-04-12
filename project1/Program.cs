using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(1234)); //1234 -> 5
        }
        public static int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n % 2;  
                n /= 2;          
            }
            return count;
        }
    }
}
