using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab20_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            char[] s;
            Write("Введите символ: ");
            c = Convert.ToChar(ReadLine());
            Write("Введите строку: ");
            s = ReadLine().ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    int size = s.Length + 1;
                    Array.Resize(ref s, size);
                    for (int j = s.Length - 2; j >= i; j--)
                    {
                        s[j + 1] = s[j];
                    }
                    i++;

                }
            }
            string otvet = new string(s);

            WriteLine(otvet);
        }
    }
}
