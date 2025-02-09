using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IfItsBlackShoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Targil5(869419));
            Console.Read();
        }
        static int Targil6(int[] a, int l)
        {
            if (l == -1) return 0;
            if (a[l] > 0) return 1 + Targil6(a, l - 1);
            return Targil6(a,l - 1);
        }
        static int Targil5(int num)
        {
            if (num > -1 && num < 10) return num;
            return Targil5(num % 10 + Targil5(num / 10));
        }
        static int Targil4(int n)
        {
            if (n == 0) return 0;
            return n * n + Targil4(n - 1);
        }
        static int Targil3(int x, int y)
        {
            if (y == 0) return 1;
            return x * Targil3(x, y - 1);
        }
        static int Targil2(int x, int y) 
        {
  
            if (x > y)
            return 0;
            return 1 + Targil2(x + x, y);
        }
        static void Targil1()// 1. num 2.if num == 0 3.nah 4.i dont know 
        {
            Console.WriteLine("insert number");
            int num = int.Parse(Console.ReadLine());
            Printevennumber(num);
        }
        static void Printevennumber(int num)
        {
            if (num == 0) { return; }
            int digit = num % 10;
            if (digit % 2 == 0)
                Console.WriteLine(digit);
            Printevennumber(num / 10);

        }

    }
}
