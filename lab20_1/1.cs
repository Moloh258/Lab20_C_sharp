using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Write("Введите символ: ");
            c = Convert.ToChar(ReadLine());
            WriteLine("C + 1: {0}", (char)(c + 1));
            Write("C - 1: {0}", (char)(c - 1));
        }
    }
}
