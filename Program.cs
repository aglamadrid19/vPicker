using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPicker
{

    class Program
    {
        static void Main(string[] args)
        {
            // App Name
            string AppName = "vPicker";

            // VLAN Options HashTable
            Hashtable VOptions = new Hashtable()
            {
                { "1", "DMZ DEV" },
                { "2", "DMZ SS" },
                { "3", "DMZ VVDI" },
                { "4", "NC QA" },
                { "5", "NC PROD" },
                { "6", "NC MGMT" },
                { "7", "NC VDI" },
                { "8", "C QA"},
                { "9", "C PROD SAT" },
                { "10", "C PROD SDT" },
                { "11", "CC" }
            };

            // Build Options HashTable
            Hashtable BOptions = new Hashtable()
            {
                { "1", "SERVER" },
                { "2", "VDI" },
            };

            // Build Server Options HashTable
            Hashtable BSOptions = new Hashtable()
            {
                { "1", "WINDOWS" },
                { "2", "UNIX" },
            };

            // Build VDI Options HashTable
            Hashtable BVOptions = new Hashtable()
            {
                { "1", "VENDOR" },
                { "2", "EMPLOYEE" },
            };

            // Enviroment Options HashTable
            Hashtable EOptions = new Hashtable()
            {
                { "1", "DEV" },
                { "2", "QA" },
                { "3", "PROD" }
            };

            // Console Design
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            // First menu

            Console.SetCursorPosition((Console.WindowWidth - AppName.Length) / 2, Console.CursorTop);
            Console.WriteLine(AppName);

            Console.SetCursorPosition((Console.WindowWidth - AppName.Length) / 2, Console.CursorTop);
            Console.WriteLine("-------\n");

            Console.WriteLine("Select VLAN, read your options");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");

            Console.ReadLine();
        }
    }
}
