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
            Class1 class1 = new Class1();
            TaskMaking taskMaking = new TaskMaking();
            Console.WriteLine("Input total amount Bag");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input total amount Feature");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input total amount Technical assingment ");
            int c = int.Parse(Console.ReadLine());
            Task[] ta = taskMaking.Function(a, b, c);
            class1.Solved(ta);
            Console.ReadLine();
        }
    }
}
