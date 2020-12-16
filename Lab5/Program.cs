using System;

namespace Lab5
{
    class Program
    {
        static Array _array;
        static TwoDimensionalArray _twoDimensionalArray;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Работа с одномерными массивами\n2. Работа с двумерными массивами");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        ActionsWithArray();
                        break;
                    case "2":
                        ActionsWithTwoDimensionalArray();
                        break;
                }
            }
        }

        public static void ActionsWithArray()
        {
            while (true)
            {
                Console.WriteLine("1. Создать массив\n2. Заполнить массив вручную\n3. Заполнить массив случайными числами\n4. Добавить элементы\n5. Напечатать массив\n6. Назад");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        _array = CreateArray();
                        break;
                    case "2":
                        _array.FillArray();
                        break;
                    case "3":
                        _array.FillArrayRandomElemetns();
                        break;
                    case "4":
                        _array.AddElement(5);
                        break;
                    case "5":
                        _array.PrintArray();
                        break;
                    case "6":
                        return;

                }
            }
        }

        public static void ActionsWithTwoDimensionalArray()
        {
            while (true)
            {
                Console.WriteLine("1. Создать массив\n2. Заполнить массив вручную\n3. Заполнить массив случайными числами\n4. Удалить строки\n5. Напечатать массив\n6. Назад");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        _twoDimensionalArray = CreateTwoDimensionalArray();
                        break;
                    case "2":
                        _twoDimensionalArray.FillArray();
                        break;
                    case "3":
                        _twoDimensionalArray.FillArrayRandomElemetns();
                        break;
                    case "4":
                        var k1k2 = CheckK1AndK2();
                        _twoDimensionalArray.Delete(k1k2[0],k1k2[1]);
                        break;
                    case "5":
                        _twoDimensionalArray.PrintArray();
                        break;
                    case "6":
                        return;

                }
            }
        }

        public static Array CreateArray()
        {

            Console.WriteLine("Введите размерность массива");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());
            var array = new Array(arrayLenght);

            return array;
        }

        public static TwoDimensionalArray CreateTwoDimensionalArray()
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            var twoDimensionalArray = new TwoDimensionalArray(n, m);

            return twoDimensionalArray;
        }

        public static int[] CheckK1AndK2()
        {
            int[] k1k2 = new int[2];
            while (true)
            {
                Console.Write("k1 = ");
                int k1 = Convert.ToInt32(Console.ReadLine());

                if (k1 < 0 || k1 > _twoDimensionalArray._n)
                {
                    Error();
                    continue;
                }
                k1k2[0] = k1;

                Console.Write("k2 = ");
                int k2 = Convert.ToInt32(Console.ReadLine());

                if (k2 < 0 || k2 > _twoDimensionalArray._n || k2<k1)
                {
                    Error();
                    continue;
                }
                k1k2[1] = k2;

                return k1k2;
            }




        }
        private static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error");
            Console.ResetColor();

        }
    }
}
