using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class singleton 
    {
        private static int counter;


        private singleton()
        {
            counter += 1;
            Console.WriteLine("Instance Number " + counter.ToString());

        }


        public static singleton getInstance()
        {
            return new singleton();

        }

    }
}
