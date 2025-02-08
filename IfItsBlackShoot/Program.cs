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
;
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
            Printevennumber(digit);
            if (digit % 2 == 0)
                Console.WriteLine(digit );
        }

    }
}
