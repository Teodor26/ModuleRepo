using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Class1
    {

        public void Solved(Task[] ta)
        {
            double time;
            double count = 30.0;
            for (int i = 0; i < ta.Length; i++)
            {
                time = ta[i].Time();
                count = count-time;
                if (count <= 0)
                {
                    Console.WriteLine(ta[i].Solved);
                }
            }

        }


    }
}
