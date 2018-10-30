using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Class1
    {

        void Solved(Task[] ta)
        {
            double count = 30.0;
            for (int i = 0; i < ta.Length; i++)
            {
                double time = ta[i].Time();
                time = count-time;
                if (time <= 0)
                {
                    Console.WriteLine(ta[i].Solved);
                }
            }

        }


    }
}
