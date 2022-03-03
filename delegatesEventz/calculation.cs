using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using delegatesEventz;
using System.Threading.Tasks;

namespace delegatesEventz
{
    class calculation
    {
        public void addition(int x, int y)
        {
            Console.WriteLine("Addition is " + (x + y));
        }
        public void subtraction(int x, int y)
        {
            Console.WriteLine("Subtraction is " + (x - y));
        }
        public void multiplication(int x, int y)
        {
            Console.WriteLine("Multiplication is " + (x * y));
        }
    }
}
