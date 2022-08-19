using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string content = File.ReadAllText("D:\\Hariyono\\database\\sqlserver\\constrain.sql");

            Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something wrong!!");
                Console.WriteLine("ex.Message" + ex.Message);
                Console.WriteLine("ex.StackTrace" +  ex.StackTrace);
                Console.WriteLine("ex.InnerException" +  ex.InnerException);
                Console.WriteLine("ex.TargetSite" +  ex.TargetSite);
                Console.WriteLine("ex.Data" +  ex.Data);
            }
            finally
            {
                //Closing connection database
                //Setting object to null
                Console.WriteLine("Disconnection your application");
            }
            Console.ReadLine();
        }
    }
}
