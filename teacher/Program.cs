using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = 0; i < a.Split(' ').Length; i++) Console.WriteLine(a.Split(' ')[i]);

        }
    }
}
