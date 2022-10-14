using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> myDictonary = new Dictonary.MyDictonary<int, string>();
            myDictonary.Add(1, "Mikdat");
            myDictonary.Add(2, "Batuhan");
            myDictonary.Add(3, "Umut");
            myDictonary.Add(5, "Ahmet");
            Console.WriteLine("İsim değeri sayisi= " + myDictonary.CountT1 + "  Yaş Degeri Sayisi: " + myDictonary.CountT2);

            Console.ReadLine();
        }
    }

    class MyDictonary<T1,T2>
    {
        T1[] _array1;
        T1[] _tempArray1;
        T2[] _array2;
        T2[] _tempArray2;

        public MyDictonary()
        {
            _array1 = new T1[0];
            _array2 = new T2[0];
        }

        public void Add(T1 item1, T2 item2)
        {
            _tempArray1 = _array1;
            _tempArray2 = _array2;

            _array1 = new T1[_array1.Length + 1];
            _array2 = new T2[_array2.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
                _array2[i] = _tempArray2[i];
            }
            _array1[_array1.Length - 1] = item1;
            _array2[_array2.Length - 1] = item2;
        }

        public int CountT1
        {
            get { return _array1.Length; }
        }

        public int CountT2
        {
            get { return _array2.Length; }
        }
    }
}
