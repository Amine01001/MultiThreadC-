using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class design
    {
        public static void kekername()
        {
            string[] ascii = new string[]
          {
                "                                                                                   ",
                "           ███    ███ ██    ██ ██      ████████ ██     ████████ ██   ██ ██████  ███████  █████  ██████  ",
                "           ████  ████ ██    ██ ██         ██    ██        ██    ██   ██ ██   ██ ██      ██   ██ ██   ██ ",
                "           ██ ████ ██ ██    ██ ██         ██    ██        ██    ███████ ██████  █████   ███████ ██   ██ ",
                "           ██  ██  ██ ██    ██ ██         ██    ██        ██    ██   ██ ██   ██ ██      ██   ██ ██   ██ ",
                "           ██      ██  ██████  ███████    ██    ██        ██    ██   ██ ██   ██ ███████ ██   ██ ██████  ",
                "                                                                                                        ",
                "                                                                                                        ",
                "                                              Github : Amine01001                                       ",
        };

            for (int i = 0; i < ascii.Length; i++)
                Console.WriteLine("  " + ascii[i], Color.Red);
        }
        
    }
}
