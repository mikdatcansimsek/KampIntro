using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 20;
            //int number2 = 100;

            //var result1 = Add(ref number1, number2);
            //Console.WriteLine(result1);
            //Console.WriteLine(number1);

            //int number1 = 5;
            //int number2 = 10;
            //int number3 = 20;

            //int result = multiply(number1, number2,number3);


            Console.WriteLine(Add2(2,3,4,5,11,23));
            Console.ReadLine();
        }

        static int Add( ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int multiply(int number1, int number2)
        {

            return number1 * number2;
        }

        static int multiply(int number1, int number2, int number3)
        {
            return number2 * number3 * number1;
        }

        static int Add2(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
