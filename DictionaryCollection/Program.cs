using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,object> dt = new Dictionary<string,object>();
            dt.Add("Id", 1001);
            dt.Add("Name", "Manideep");
            dt.Add("Email", "manideep.n15@gmail.com");
            dt.Add("Address", "Hyderabad");

            foreach(var key in dt.Keys)
            {
                Console.WriteLine(key + ":" + dt[key]);
            }
           
        }
    }
}
