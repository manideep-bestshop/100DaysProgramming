using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteReadFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamWriter streamWriter = new StreamWriter("C:\\MyFolders\\Study\\ConsoleApplications\\Collections.txt");

                streamWriter.WriteLine("Hello World...");

                streamWriter.WriteLine("From the StreamWriter");

                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
