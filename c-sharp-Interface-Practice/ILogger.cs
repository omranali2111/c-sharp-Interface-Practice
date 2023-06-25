using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface_Practice
{
    /*
     * Task 4:
Create an interface ILogger with the following methods:

void LogInfo(string message)
void LogError(string errorMessage)
Create two classes FileLogger and DatabaseLogger that 
    implement the ILogger interface. Implement the methods to
    log information and errors to a file and a database, respectively.
*/
    internal interface ILogger
    {
         public void LogInfo(string message);
        public void LogError(string message);

    }

    class FileLogger: ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now}: {message}");

        }
        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");

        }

    }
    class DatabaseLogger: ILogger
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");

        }


    }

}
