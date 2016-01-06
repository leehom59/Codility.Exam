using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekors.Codility.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 t1 = new Task1();
            //t1.solution(4, 17);

            Task3 t3 = new Task3();
            Tree t = new Tree() { x = 5  };
            t.l = new Tree() { x = 3, l = new Tree() { x = 20 }, r = new Tree() { x = 21 } };
            t.r = new Tree() { x = 10, l = new Tree() { x = 1 } };
            int RS = t3.solution(t);
           

            Console.WriteLine(RS);
            Console.ReadKey();
        }
    }
}
