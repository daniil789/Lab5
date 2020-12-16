using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Array
    {
        int[] _array;

        public Array(int n)
        {
            _array = new int[n];
        }

        public void AddElement(int k)
        {
            int[] newArray = new int[_array.Length + k];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < k; i++)
            {
                int newElement = Convert.ToInt32(Console.ReadLine());
                newArray[_array.Length + i] = newElement;
            }

            _array = newArray;

        }

        public void FillArray()
        {
            Console.WriteLine("Заполните массив");

            for (int i = 0; i < _array.Length; i++)
            {
                int newElement = Input();
                _array[i] = newElement;
            }
        }

        public void FillArrayRandomElemetns()
        {
            var random = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(20);
            }
        }

        public void PrintArray()
        {

            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"{i} - {_array[i]}");
            }
        }

        private int Input()
        {
            while (true)
            {
                try
                {
                    int newElement = Convert.ToInt32(Console.ReadLine());
                    return newElement;
                }
                catch
                {
                    Error();
                    continue;
                }
            }
        }

        private void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error");
            Console.ResetColor();

        }
    }
}
