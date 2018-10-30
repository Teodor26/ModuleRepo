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
            double time;
            double count = 30.0;
            for (int i = 0; i < ta.Length; i++)
            {

                time = ta[i].Time();
                count = count - time;
                if (count <= 0)
                {
                    Random rand = new Random();
                    
                    if(rand.Next(0,5)==1)
                    {
                        time = count - time;
                    }
                    Console.WriteLine(ta[i].Solved);
                }
            }

        }




    }
}
