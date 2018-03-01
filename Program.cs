using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Recursion
    {
        public int factorial(int num)
        {
            /* local variable declaration */
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        static void Main(string[] args)
        {
            var n = new Recursion();
            
            Console.WriteLine("Factorial of 2 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial of 5 is : {0}", n.factorial(8));
            Console.ReadLine();
        }
    }
}
