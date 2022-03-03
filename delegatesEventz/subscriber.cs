using delegatesEventz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesEventz
{
    class subscriber
    {
        static void Main(string[] args)
        {
            publisher publish = new publisher();
            calculation calculate = new calculation();
            publish.even += new operation(calculate.addition);
            publish.even += new operation(calculate.subtraction);
            publish.even += new operation(calculate.multiplication);
            Console.WriteLine("Enter values");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            publish.invokeMethod(x, y);
        }
    }


}
