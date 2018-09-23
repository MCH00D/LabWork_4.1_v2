using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_4._1_v2
{
    class Program
    {
        static void Main(string[] args)
        {

            var primeNumber = new PrimeNumber();
            foreach (var item in primeNumber)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public class PrimeNumber : IEnumerable, IEnumerator
    {
        private int[] array;
        int pointer;

        public PrimeNumber()
        {
            array = new int[] { 55, 44, 1, 4, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            pointer = 0;
        }

        public object Current => array[pointer - 1];

        public bool MoveNext()
        {
            if (pointer == array.Length)
            {
                Reset();
                return false;
            }

            for (int i = pointer; i < array.Length; i++)
            {
                if (IsPrimeNumber(array[i]))
                {
                    pointer = ++i;
                    return true;
                }
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            pointer = 0;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
                {
                    return false;
                }

            }

            return true;

        }

    }
}
