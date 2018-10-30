using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class TaskMaking
    {
        public int Bag;
        public int Feature;
        public int TechnialID;        

        public Task[] Function(int firstNumber, int SecondNumber, int ThirdNumber)
        {
            Task[] task = new Task[firstNumber + SecondNumber+ ThirdNumber];

            Bag = firstNumber;
            Feature = SecondNumber;
            TechnialID = ThirdNumber;

            for (int i = 0; i < Bag; i++)
            {
                task[i] = new Bug();
                task[i].Name = "Bug # " + i;
                task[i].NewTask(task[i].Name);
            }

            for (int i = Bag; i < Feature; i++)
            {
                task[i] = new Feature();
                task[i].Name = "Feature # " + i;
                task[i].NewTask(task[i].Name);
            }

            for (int i = Feature; i < TechnialID; i++)
            {
                task[i] = new TechnicalDuty();
                task[i].Name = "TechnialID # " + i;
                task[i].NewTask(task[i].Name);
            }

            return task;
        }

    }
}
