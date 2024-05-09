using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList numberList = new ArrayList();
            numberList.Add(1);
            numberList.Add(2);

            Console.WriteLine("Capacity :"+numberList.Capacity);
            Console.WriteLine("Array List");

            numberList.Insert(0,7);

            numberList.Remove(7);

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
