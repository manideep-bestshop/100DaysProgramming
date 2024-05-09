using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text;
            try
            {

                StreamReader streamReader = new StreamReader("C:\\MyFolders\\Study\\ConsoleApplications\\Collections.txt");

                text = streamReader.ReadLine();

                while (text != null)
                {

                    Console.WriteLine(text);

                    text = streamReader.ReadLine();
                }

                streamReader.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executed finally block.");
            }
           
        }
    }
}
