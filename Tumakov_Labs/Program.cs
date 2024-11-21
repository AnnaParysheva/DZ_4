using System;

namespace Tumakov_Labs
{
    internal class Program
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Exchange(ref int a, ref int b)
        {
            int kopi = a;
            a = b;
            b = kopi;
        }
        static bool Factorial(int n, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        static long Rec_factorial(int n)
        {
            if (n == 0) return 1;
            return n * Rec_factorial(n - 1);
        }
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static int NOD(int a, int b, int c)
        {
            return NOD(NOD(a, b), c);
        }
        static long Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            //Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода – два целых числа.Протестировать метод.
            Console.WriteLine("Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные параметры метода – два целых числа. Протестировать метод.");
            Console.Write("Введите первое число: ");
            int n11 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n12 = int.Parse(Console.ReadLine());
            int max_n = Max(n11, n12);
            Console.WriteLine($"Наибольшее число: {max_n}");
            // Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых параметров.Параметры передавать по ссылке. Протестировать метод.
            Console.WriteLine("Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых параметров. Параметры передавать по ссылке. Протестировать метод.");
            Console.Write("Введите первое число: ");
            int n21 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n22 = int.Parse(Console.ReadLine());
            Exchange(ref n21, ref n22);
            Console.WriteLine($"После обмена: первое число = {n21}, второе число = {n22}");
            // Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true; если в процессе вычисления возникло переполнение, то вернуть значение false.Для отслеживания переполнения значения использовать блок checked.
            Console.WriteLine("Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true; если в процессе вычисления возникло переполнение, то вернуть значение false.Для отслеживания переполнения значения использовать блок checked.");
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (Factorial(number, out long factorial))
                Console.WriteLine($"{number}! = {factorial}");
            else
                Console.WriteLine("Произошло переполнение при вычислении факториала.");
            // Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.
            Console.WriteLine("Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.");
            Console.Write("Введите число для вычисления факториала: ");
            int num = int.Parse(Console.ReadLine());
            long rec_factorial = Rec_factorial(num);
            Console.WriteLine($"Факториал {num} = {rec_factorial}");
            //Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех натуральных чисел.
            Console.WriteLine("Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех натуральных чисел.");
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"НОД двух чисел: {NOD(num1, num2)}");
            Console.WriteLine($"НОД трех чисел: {NOD(num1, num2, num3)}");
            // Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8, 13... Для таких чисел верно соотношение Fk = Fk - 1 + Fk - 2.
            Console.WriteLine("Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.");
            Console.Write("Введите номер числа Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());
            long num_fib = Fibonacci(n);
            Console.WriteLine($"{n} число ряда Фибоначчи = {num_fib}");
            Console.ReadKey();
        }
    }
}
