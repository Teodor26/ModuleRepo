using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input total amount Bag");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input total amount Feature");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input total amount Technical assingment ");
            int c = int.Parse(Console.ReadLine());
            Function(a, b, c);


        }
    }
}
