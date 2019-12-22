using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab20_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку: ");
            s = ReadLine();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((char)s[i] >= 'A' && (char)s[i] <= 'Z' || (char)s[i] >= 'a' && (char)s[i] <= 'z')
                {
                    k++;
                }
            }

            Write("Количество: {0}", k);
        }
    }
}
