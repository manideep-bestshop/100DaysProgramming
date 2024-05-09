using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HashCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Id", 1001);
            hashtable.Add("Name", "Manideep");
            hashtable.Add("Email", "manideep.n15@gmail.com");
            hashtable.Add("Address", "Hyderabad");

            Console.WriteLine(hashtable["Address"]);

            foreach(var key in hashtable.Keys)
            {
                Console.WriteLine(key +": " + hashtable[key]);
            }
        }
    }
}
