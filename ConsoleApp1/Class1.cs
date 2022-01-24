using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp1
{
	class thread
	{
		private static List<Thread> shit = new List<Thread>();
		public static void Start3()
		{
			for (int i = 0; i < Vars.threads; i++)
			{
				shit.Add(new Thread(new ThreadStart(go)));
				shit.Add(new Thread(new ThreadStart(goo)));
			}
			foreach (Thread thread in shit)
			{
				thread.Start();
			}
			for (int j = 0; j < shit.Count; j++)
			{
				shit[j].Join();
			}
		}
		public static void go()
        {
			Console.WriteLine("test");
        }
		public static void goo()
		{
			Console.WriteLine("test2");
		}
	}
}
