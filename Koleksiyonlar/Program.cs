using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();

            isimler.Add("Mikdat");
            isimler.Add("Beren");

            Console.WriteLine(isimler[0] + " " + isimler[1]);
            Console.ReadLine();
        }
    }
}
