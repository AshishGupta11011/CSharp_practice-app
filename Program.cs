using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_practice
{
    class Program
    {
        public struct myStruct {
            public int x;
        }
        static void Main(string[] args)
        {
            myStruct p1;
            p1.x = 2;
            Console.WriteLine("p1.x" + p1.x);

            myStruct p2 = p1;
            p2.x = 3;
            Console.WriteLine( "p2.x  = " + p2.x);
			Console.WriteLine("heyyy");
            Console.ReadLine();
        }
    }
}
