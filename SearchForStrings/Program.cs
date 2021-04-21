using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new StringSearcher();
            numbers.S1 += RequiredLine;
            numbers.Search();

            Console.ReadLine();
        }

        static void RequiredLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
