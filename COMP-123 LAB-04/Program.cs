using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_LAB_04
{
    class Program
    {
        static void Main(string[] args)
        {   // intantiate object 
            Person sukh = new Person("Sukhjinder Kaur",30);

            //call method with .accessor
            sukh.SayHello();
            Console.ReadLine();
        }
    }
}
