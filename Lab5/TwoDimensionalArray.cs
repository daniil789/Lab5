using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class TwoDimensionalArray
    {
        int[,] _array;
        public int _n;
        int _m;

        public TwoDimensionalArray(int n, int m)
        {
            _n = n;
            _m = m;
            _array = new int[n, m];
        }

        public void FillArray()
        {
            Console.WriteLine("Заполните массив");

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    int newElement = Input();
                    _array[i, j] = newElement;
                }
            }
        }

        public void FillArrayRandomElemetns()
        {
            var random = new Random();

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {

                    _array[i, j] = random.Next(10, 100);

                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _m; j++)
                {
                    Console.Write($"{_array[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        public void Delete(int k1, int k2)
        {
            int n = _n - k2 - k1 + 1;
            int[,] newArray = new int[n, _m];
            int x = 0;
            for (int i = 0; i < _n; i++)
            {
                if (i < k1 || i > k2)
                {
                    for (int j = 0; j < _m; j++)
                    {
                        newArray[x, j] = _array[i, j];
                    }
                    x++;
                }
            }
            _n = n;
            _array = newArray;
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
