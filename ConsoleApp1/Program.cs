using System;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;


namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            design.kekername();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  {+} Enter Threads numb");
            Console.Write("  => ");
            Vars.threads = int.Parse(Console.ReadLine());
            thread.Start3();
           
        }
    }
}
