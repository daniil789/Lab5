using System;

namespace Lab5
{
    class Program
    {
        static Array _array;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Работа с одномерными массивами");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        ActionsWithArray();
                        break;
                }
            }
        }

        public static void ActionsWithArray()
        {
            while (true)
            {
                Console.WriteLine("1. Создать массив 2. Заполнить массив вручную 3. Заполнить массив случайными числами 4. Добавить элементы 5. Напечатать массив 6. Назад");

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

        public static Array CreateArray()
        {

            Console.WriteLine("Введите размерность массива");
            int arrayLenght = Convert.ToInt32(Console.ReadLine());
            var array = new Array(arrayLenght);

            return array;
        }
    }
}
