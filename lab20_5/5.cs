using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab20_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s0;
            int i = 0, k = -1, c = -1;
            Write("Введите первую строку: ");
            s = ReadLine();
            Write("Введиту вторую строку: ");
            s0 = ReadLine();

            while (i != -1)
            {
                i = s.IndexOf(s0, k + 1);
                k = i;
                c++;
            }
            Write(c);
        }
    }
}
