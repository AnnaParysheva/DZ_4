using System;

namespace Files_Labs
{
    internal class Program
    {
        static double Calculation_Array(out double sr_arif, ref long proizv, params int[] array)
        {
            double sum = 0;
            proizv = 1;
            foreach (int number in array)
            {
                sum += number;
                proizv *= number;
            }
            sr_arif = sum / array.Length;
            return sum;
        }
        static void Draw_Digit(int digit)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine(" #### \n#    #\n#    #\n#    #\n #### ");
                    break;
                case 1:
                    Console.WriteLine("   # \n   # \n   # \n   # \n   # ");
                    break;
                case 2:
                    Console.WriteLine(" #### \n     #\n #### \n#     \n #### ");
                    break;
                case 3:
                    Console.WriteLine(" #### \n     #\n #### \n     #\n #### ");
                    break;
                case 4:
                    Console.WriteLine("#   # \n#   # \n #### \n    # \n    # ");
                    break;
                case 5:
                    Console.WriteLine(" #### \n#     \n #### \n     #\n #### ");
                    break;
                case 6:
                    Console.WriteLine(" #### \n#     \n #### \n#   # \n #### ");
                    break;
                case 7:
                    Console.WriteLine(" #### \n     #\n     #\n     #\n     # ");
                    break;
                case 8:
                    Console.WriteLine(" #### \n#   # \n #### \n#   # \n #### ");
                    break;
                case 9:
                    Console.WriteLine(" #### \n#   # \n #### \n     #\n #### ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            // 1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива, которые нужно поменять местами. Вывести на экран получившийся массив.
            Console.WriteLine("1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,которые нужно поменять местами. Вывести на экран получившийся массив.");
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(1, 1001);
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));
            Console.Write("Введите первое число для обмена: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число для обмена: ");
            int number2 = int.Parse(Console.ReadLine());
            int ind1 = Array.IndexOf(array, number1);
            int ind2 = Array.IndexOf(array, number2);
            if (ind1 == -1 || ind2 == -1)
            {
                Console.WriteLine("Числа не найдены в массиве.");
            }
            else
            {
                (array[ind1], array[ind2]) = (array[ind2], array[ind1]);

            }
            Console.WriteLine($"Массив после обмена: {string.Join(", ", array)}");
            // 2. Написать метод, где в качества аргумента будет передан массив (ключевое слово params). Вывести сумму элементов массива(вернуть). Вывести(ref) произведение массива.Вывести(out) среднее арифметическое в массиве.
            Console.WriteLine("2. Написать метод, где в качества аргумента будет передан массив (ключевое слово params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение массива. Вывести (out) среднее арифметическое в массиве.");
            long proizv = 1;
            double sum = Calculation_Array(out double sr_arif, ref proizv, 1, 2, 3, 4, 5);
            Console.WriteLine($"Сумма элементов: {sum}");
            Console.WriteLine($"Произведение элементов: {proizv}");
            Console.WriteLine($"Среднее арифметическое: {sr_arif}");
            //3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа завершает работу, если пользователь введёт слово: exit или закрыть(оба варианта должны сработать) - консоль закроется.
            Console.WriteLine("3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта должны сработать) - консоль закроется.");
            while (true)
            {
                Console.Write("Введите цифру от 0 до 9 или 'exit'/'закрыть' для выхода: ");
                string num = Console.ReadLine();
                if ((num.ToLower() == "exit") || num.ToLower() == "закрыть")
                {
                    break;
                }
                if (int.TryParse(num, out int digit) && digit >= 0 && digit <= 9)
                {
                    Draw_Digit(digit);
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка! Введите цифру от 0 до 9.");
                    System.Threading.Thread.Sleep(3000);
                    Console.ResetColor();
                }  
            }
            Console.ReadKey();
        }
    }
}
