using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public static class Program
    {
        public static int WordCount(this StringBuilder sb)
        {
            return sb.ToString().Split(' ').Length;
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
      
            Console.WriteLine("Number of words " +"'" +sb +  "' is " + WordCount(sb));

            Console.ReadKey();
        }
    }
}
