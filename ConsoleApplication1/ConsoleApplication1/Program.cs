using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = b - a;
            string u;
            Console.WriteLine("Haloo, nilai c = {0} dan b = {1}", c, b);
            Console.WriteLine("Nilai Modulus {0} mod {1} = {2}", b, a, b % a);
            Console.Write("Masukkan umur Anda : ");
            u = Console.ReadLine();
            Console.WriteLine("jadi umur anda {0} tahun yaa", u);
            if (a > b)
            { Console.WriteLine("a({0}) lebih besar dari b({1})", a, b); }
            else if (b > a)
            { Console.WriteLine("b({0}) lebih besar dari a({1})", b, a); }
            else if (b == a)
            { Console.WriteLine("a({0}) sama dengan b({1})", a, b);      }
            switch (a)
            {
                case 5:
                    Console.WriteLine("Lima");
                    break;
                case 10:
                    Console.WriteLine("Sepuluh");
                    break;
                case 8:
                    Console.WriteLine("delapan");
                    break;
                default:
                    Console.WriteLine("not found..");
                    break;
            }

        }

    }
}
