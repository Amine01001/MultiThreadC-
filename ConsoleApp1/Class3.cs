using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vars
    {
        public static int threads=0;
        public static int combolen = 0;
        public static int count = 0;
        public static ConcurrentQueue<string> list = new ConcurrentQueue<string>();
    }
}
