using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSysterm
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            do
            {
                Console.Clear();

                Console.Title = "STUDENT SYSTEM";

                Console.BackgroundColor = ConsoleColor.Blue;

                Console.ForegroundColor = ConsoleColor.White;                
                Console.SetCursorPosition(20, 5);
                Console.WriteLine("1. Register a student.");
                Console.SetCursorPosition(20, 7);
                Console.WriteLine("2. Search.");
                Console.SetCursorPosition(20, 9);
                Console.WriteLine("3. Remove a student.");
                Console.SetCursorPosition(20, 11);
                Console.WriteLine("4. Register a teacher.");
                Console.SetCursorPosition(20, 13);
                Console.WriteLine("5. Load from file.");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(25, 16);
                Console.WriteLine("Press Q to exit.");

            }
            while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }
    }
}
