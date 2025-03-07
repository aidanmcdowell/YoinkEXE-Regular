using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YoinkEXE
{
    internal class Yoink_Console
    {
        public static string Title { get; private set; }
        public static ConsoleColor ForegroundColor { get; private set; }

        public static void Console(string[] args)
        {
            Title = "Rox";
            ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("\\ \\      // //                                           ");
            System.Console.WriteLine(" \\ \\    // //    ______       |||                |||     ");
            System.Console.WriteLine("  \\ \\  // //   //------\\           |||          |||  // ");
            System.Console.WriteLine("   \\ \\// //   //        \\    |||   |||||||||||  ||| //  ");
            System.Console.WriteLine("     ||  ||     ||         ||   |||   |||     |||  |||//   ");
            System.Console.WriteLine("     ||  ||     ||         ||   |||   |||     |||  |||\\   ");
            System.Console.WriteLine("     ||  ||     \\         //   |||   |||     |||  ||| \\  ");
            System.Console.WriteLine("     ||__||      \\=======//    |||   |||     |||  |||  \\ ");
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("\n\n                                 -- Input \"inject\" to inject the exploit. --\n\n");
            System.Console.ResetColor();
        }
    }
}