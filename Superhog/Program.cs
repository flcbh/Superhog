using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The WorkItOut class was separated in this context to achieve greater readability for the code.
            Console.WriteLine(WorkItOut.GetPalindrome());
            Console.Read();
        }
    }
}
