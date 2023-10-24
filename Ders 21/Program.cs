using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            var result3 = Add3(4);
            Console.WriteLine(result3);

            Console.WriteLine(result);
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(int x, int number1=20, int number2=30)
        {
            var result3 = number1 + number2;
            return result3;
        }
    }
}
