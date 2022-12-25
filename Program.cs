using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyPracticeWork
{
    internal class Program
    {
        static void Main() {
            EleventhPractice.ThirdNumber();
            Console.ReadKey();
        }
    }
    internal class FirstPractice {
        internal static void FirstNumber() {
            Console.WriteLine("Введите сторону a > 0");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b > 0");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь - {a * b}, периметр - {(a + b) * 2}");
        }
        internal static void SecondNum() {
            Console.WriteLine("Введите скорость первого авто");
            double firstSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость второго авто");
            double secondSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальное расстояние между машинами");
            double way = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите T (Количество часов)");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Расстояни между ними через {hours} час/а - {way + firstSpeed * hours + secondSpeed * hours} км");
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите радиус шара >= 0");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Объём шара - {4F / 3F * Math.PI * (Math.Pow(R, 3))}");
        }
        internal static void FourthNumber() {
            Console.WriteLine("Введите x - не равный 0");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Z = {(x + ((2 + y) / (x * x))) / (y + (1 / (Math.Sqrt(Math.Pow(x, 2) + 10))))}");
        }
        internal static void FifthNumber() {
            Console.WriteLine("Введите количество секунд");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Полных часов прошло - {n / 60 / 60}");
        }
    }
    internal class SecondPractice {
        internal static void FirstNumber() {
            Console.WriteLine("Введите рост ученика a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ученика b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ученика c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ученика d");
            double d = Convert.ToDouble(Console.ReadLine());

            double maxNum = Math.Max(Math.Max(a, b), Math.Max(c, d));
            string s = "";
            if ((a <= 0) || (b <= 0) || (c <= 0) || (d <= 0)) {
                throw new ArgumentException($"Значения не мб <= 0, ваши - {a} {b} {c} {d}");
            }
            if (maxNum == a) { //may use switch-case construction
                s += "a ";
            }
            if (maxNum == b) {
                s += "b ";
            }
            if (maxNum == c) {
                s += "c ";
            }
            if (maxNum == d) {
                s += "d ";
            }
            Console.WriteLine($"Самый высокий/е ученики - {s}с ростом {maxNum}");

        }
        internal static void SecondNumber() {
            Console.WriteLine("Введите радиус круга");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость волка");
            double wolfSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость шапочки");
            double girlSpeed = Convert.ToDouble(Console.ReadLine());

            if ((wolfSpeed <= 0) || (girlSpeed <= 0)) {
                throw new ArgumentException($"Скорость не мб <= 0, ваша - {wolfSpeed} {girlSpeed}");
            } if ((R < 0)) {
                throw new ArgumentException($"R не мб < 0, ваш - {R}");
            }

            if ((R * Math.PI) / girlSpeed < R * 2 / wolfSpeed) {
                Console.WriteLine("Шапочка быстрее");
            } else if ((R * Math.PI) / girlSpeed == R * 2 / wolfSpeed) {
                Console.WriteLine("Они придут в точку одновременно");
            } else {
                Console.WriteLine("Волк быстрее");
            }
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите площадь круга");
            int circleS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь квадрата");
            int squareS = Convert.ToInt32(Console.ReadLine());

            if ((circleS < 0) || (squareS < 0)) {
                throw new ArgumentException($"Показатели не мб < 0, ваши - {circleS} {squareS}");
            } 
            if (2 * Math.Sqrt(circleS / Math.PI) <= Math.Sqrt(squareS)) {
                Console.WriteLine("Уместится");
            } else {
                Console.WriteLine("Нет");
            }
        }
        internal static void FourthNumber() {
            Console.WriteLine("Введите двузначное число");
            int a = Convert.ToInt32(Math.Floor(Math.Abs(Convert.ToDouble(Console.ReadLine()))));
            if ((a >= 10 && a < 100) || (a <= -10 && a > -100)){
                if (a / 10 > a % 10){
                    Console.WriteLine("Первая цифра числа больше");
                } else if (a % 10 > a / 10) {
                    Console.WriteLine("Вторая цифра числа больше");
                } else {
                    Console.WriteLine("Цифры одинаковы");
                }
            } else {
                throw new ArgumentException($"Число не двузначное");
            }
        }
        internal static void FifthNumber() {
            Console.WriteLine("Введите аргумент\n" +
                              "a - расчет площади квадрата\n" +
                              "b - расчёт площади треугольника\n" +
                              "c - расчёт площади прямоугольника\n" +
                              "d - расчёт площади круга");
            string some = Convert.ToString(Console.ReadLine());

            if (some == "a") { // We may use switch-case construction like that: switch(some){ case "a": ...brake}. But... our topic is if constructions .... yeah switch-case is also conditional operator, i just hate it
                Console.WriteLine("Введите сторону квадрата");
                double a = Convert.ToDouble(Console.ReadLine());

                if (a >= 0) {
                    Console.WriteLine($"Площадь квадрата - {Math.Pow(a, 2)}");
                } else {
                    throw new ArgumentException($"Сторона квадрата не мб < 0, у вас - {a}");
                }

            } else if (some == "b") {
                Console.WriteLine("Введите сторону a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту h");
                double h = Convert.ToDouble(Console.ReadLine());

                if ((a > 0) && (h > 0)) {
                    Console.WriteLine($"Площадь треугольника - {a * h / 2}");
                } else {
                    throw new ArgumentException($"Значения не мб <= 0 a - {a}, b - {h}");
                }

            } else if (some == "c") {
                Console.WriteLine("Введите сторону a");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону b");
                double b = Convert.ToDouble(Console.ReadLine());

                if ((a > 0) && (b > 0)) {
                    Console.WriteLine($"Площадь прямоугольника - {a * b}");
                } else {
                    throw new ArgumentException($"Значения не мб <= 0 a - {a}, b - {b}");
                }

            } else if (some == "d") {
                Console.WriteLine("Введите радиус окружности r");
                double r = Convert.ToDouble(Console.ReadLine());

                if (r >= 0) {
                    Console.WriteLine($"Площадь круга - {Math.PI * Math.Pow(r, 2)}");
                } else {
                    throw new ArgumentException($"Значениe радиуса не мб < 0, ваше - {r}");
                }

            } else {
                throw new Exception("Неизвестный аргумент, попробуйте снова. \nUnexpected Error. Page not found 404");
            }
        }
    }
    internal class ThirdPractice {
        internal static void FirstNumber() {
            for (int i = 2; i <= 200; i += 2) {
                Console.Write(i + " ");
            }
        }
        internal static void SecondNumber() {
            for (int i = 10; i <= 150; i += 10) {
                Console.WriteLine(i);
            }
        }
        internal static void ThirdNumber() {
            float res = 0F;
            Console.WriteLine("Введите целое n >= 2");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2) {
                throw new ArgumentException($"Число должно быть >= 2. Ваше - {n}");
            }

            for (int i = n; i >= 2; i--) {
                res += 1F / i;
            }
            Console.WriteLine(res);
        }
        internal static void FourthNumber() {
            for (int i = 107; i <= 200; i += 7) {
                Console.WriteLine("Шар под номером - " + i);
            }
        }
        internal static void FifthNumber() {
            Console.WriteLine("Введите количество вводимых чисел (n)");
            int n = Convert.ToInt32(Console.ReadLine());

            int zeroes = 0;
            int plus = 0;
            int minus = 0;
            Console.WriteLine("Вводите числа через Enter");
            for (int i = 0; i < n; i++) {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    minus++;
                }
                else if (num > 0) {
                    plus++;
                } else {
                    zeroes++;
                }
            }
            Console.WriteLine($"Положительных чисел - {plus}\n" +
                              $"Отрицательных чисел - {minus}\n" +
                              $"Нулей - {zeroes}");
        }
        internal static void SixthNumber() {
            bool flag = true;
            while (true) {
                Console.WriteLine("Введите число > 5");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0) {
                    Console.WriteLine("La commedia è finita \n" +
                                      "Program was stopped, thx for using");
                    break;
                }

                if ((num <= 5) && (flag)) {
                    Console.WriteLine("More than 5 pls");
                    continue;
                }

                if (num == 22) {
                    flag = false;
                    continue;
                }


                if (flag) {
                    for (int i = 1; i <= num; i++) {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    internal class FourthPractice {
        internal static void FirstNumber() {
            double[] arr = new double[10];
            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < 10; i++) {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++) {
                Console.Write(arr[i] + " ");
            }
        }
        internal static void SecondNumber() {
            double[] arr = new double[10];
            Console.WriteLine("Введите первый член прогрессии");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите разность");
            double p = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = a + i * p;
            }

            Console.WriteLine("Ваш массив - ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите размер массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("Ваш abs массив - ");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }
        internal static void FourthNum() {
            Console.WriteLine("Введите размер массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Введите а");
            double a = Convert.ToDouble(Console.ReadLine());

            double summTwenty = 0;
            double summA = 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] <= 20) {
                    summTwenty += arr[i];
                }
                if (arr[i] > a) {
                    summA += arr[i];
                }
            }
            Console.WriteLine($"Сумма элементов <= 20 - {summTwenty}");
            Console.WriteLine($"Сумма элементов > a({a}) - {summA}");
        }

    }
    internal class FifthPractice {
        internal static void FirstNumber() {
            int[,] arr = new int[5, 4];
            Console.WriteLine("Выберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("Введите 20 значений через Enter");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 4; j++) {
                            arr[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 4; j++) {
                            arr[i, j] = rnd.Next(10);
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine("Ваш изменённый массив - ");
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 4; j++) {
                    if (arr[i, j] < 5) {
                            arr[i, j] = 111;
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        internal static void SecondNumber() {
            int[,] arr = new int[4, 5];
            bool flag = false;
            string line = "";
            Console.WriteLine("Выберите способ заполнения массива:\n" +
                  "'1' - С клавиатуры\n" +
                  "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("Введите 20 значений через Enter");
                    for (int i = 0; i < 4; i++) {
                        for (int j = 0; j < 5; j++) {
                            arr[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 4; i++) {
                        for (int j = 0; j < 5; j++) {
                            arr[i, j] = rnd.Next(11);
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 5; j++) {
                    if (arr[i, j] == 10) {
                        flag = true;
                    }
                }
                if (flag) {
                    line += $"{i+1}" + " ";
                    flag = false;
                }
            }

            if (line != "") {
                Console.WriteLine($"Строкa/и в которых есть 10 - {line}(не индекс строк/и)");
            } else {
                Console.WriteLine("Во всём массиве нет строк с 10");
            }
            
        }
        internal static void ThirdNumber() {
            double[,] arr = new double[5, 5];
            Console.WriteLine("Выберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("Введите 25 значений через Enter");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 5; j++) {
                            arr[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 5; j++) {
                            arr[i, j] = Math.Round(rnd.NextDouble() + 0.01 * 100, 2);
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив - ");
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write($"{Math.Round(Convert.ToDouble(arr[i, j]) / arr[i, 0], 2)} ");
                }
                Console.WriteLine();
            }

        }
        internal static void FourthNumber() {
            Console.WriteLine("Введите размер квадратного массива (n*n) >= 1");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] arr = new double[n, n];
            Console.WriteLine("\nВыберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {

                case 1:
                    Console.WriteLine($"\nВведите {n * n} значений через Enter");
                    for (int i = 0; i < n; i++) {
                        for (int j = 0; j < n; j++) {
                            arr[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                break;

                case 2:
                    Random rnd = new Random(100);
                    Console.WriteLine("\nВаш первоначальный rnd массив - ");
                    for (int i = 0; i < n; i++) {
                        for (int j = 0; j < n; j++) {
                            arr[i, j] = Math.Round((rnd.NextDouble() - 0.5) * 100, 2);
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                break;
               
                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            //Finding Max Value in arr
            double maxNum = arr[0, 0];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (arr[i, j] >= maxNum) {
                        maxNum = arr[i, j];
                    }
                }
            }

            //Is it any numbers >= 0?
            if (maxNum < 0) {
                Console.WriteLine("В массиве нет положительных чисел, попробуйте ещё раз");
                Environment.Exit(1);
            }

            //Finding min number >= 0
            double minPol = maxNum;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if ((arr[i, j] >= 0) && (arr[i, j] <= minPol)) {
                        minPol = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"\nМинимальное положительное число - {minPol}");

            //Making copy of array
            double[,] reversedarr = new double[n,n];
            Array.Copy(arr, reversedarr, n*n);

            //Finding column and line with minNum 
            int line = 0;
            int column = 0;
            for (int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if (arr[i, j] == minPol) {
                        line = i;
                        column = j;
                        i = n; //Breaking 2 fors
                    }
                }
            }

            //Reversing elements
            for (int i = 0; i < n; i++) {
                reversedarr[i, column] = arr[line, i];
                reversedarr[line, i] = arr[i, column];
            }

            //Printing reversedarr
            Console.WriteLine("\nМассив с обменянными строкой и столбцом");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(reversedarr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Внимание! Сначала меняется строка, а затем столбец. Возможны наложения");
        }
    }
    internal class SixthPractice {
        internal static void FirstNumber() {
            ArrayList list = new ArrayList();
            Random rnd = new Random();
            Console.WriteLine("Введите n - кол-во человек");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВаш список - ");
            for (int i = 0; i < n; i++) {
                list.Add(rnd.Next(50, 101));
                Console.Write($"{list[i]} ");
            }
        }
        internal static void SecondNumber() {
            Queue queue = new Queue();
            Console.WriteLine("Введите n - кол-во элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++) {
                double cash = Math.Round(rnd.NextDouble() + 22, 2);
                Console.Write(cash + " ");
                queue.Enqueue(cash);
            }

            Console.WriteLine("\n\nВведите k");
            double k = Convert.ToDouble(Console.ReadLine());

            if (queue.Contains(k)) {
                Console.WriteLine("\nЕсть");
            } else {
                Console.WriteLine("\nНет");
            }
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] arr = new double[n];
            Stack stack = new Stack();

            Console.WriteLine("\n'1' - Ввод чисел через клавиатуру\n" +
                              "'2' - Ввод чисел через Random");
            int some = Convert.ToInt32(Console.ReadLine());
            switch (some) {
                case 1:
                    Console.WriteLine("Вводите числа через Enter");
                    for (int i = 0; i < n; i++) {
                        arr[i] = Convert.ToDouble(Console.ReadLine());
                        if (i % 2 == 0) {
                            arr[i] *= 2;
                        } else {
                            arr[i] -= 1;
                        }
                        stack.Push(arr[i]);
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++) {
                        arr[i] = Math.Round(rnd.NextDouble() * 100, 2);
                        Console.Write(arr[i] + " ");
                        if (i % 2 == 1) {
                            arr[i] *= 2;
                        } else {
                            arr[i] -= 1;
                        }
                        stack.Push(arr[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine("\n\nПосле умножения и вычитания:\n");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nВведите 10 чисел которые нужно добавить через Enter");
            for (int i = 0; i < 10; i++) {
                stack.Push(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("\nВаш стек - ");
            for (int i = 0; i < 10 + n; i++) {
                Console.Write(stack.Pop() + " ");
            }


        }
        internal static void FourthNumber() {
            Dictionary<string, double> dictionary =
        new Dictionary<string, double>();
            Random rnd = new Random();

            Console.WriteLine("Выберите способ заполнения словаря:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("\nВведите 10 значений через Enter");
                    for (int i = 1; i <= 10; i++) {
                        Console.Write($"Candy {i} : ");
                        dictionary.Add($"Candy {i}", Convert.ToDouble(Console.ReadLine()));
                    }
                    break;

                case 2:
                    for (int i = 1; i <= 10; i++) {
                        dictionary.Add($"Candy {i}", Math.Round((rnd.NextDouble() + 0.1) * 100, 2));
                        Console.WriteLine($"Candy {i} : " + dictionary[$"Candy {i}"]);
                    }
                    break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            //Finding min price
            double minprice = dictionary["Candy 1"];
            for (int i = 1; i <= 10; i++) {
                if (minprice > dictionary[$"Candy {i}"]) {
                    minprice = dictionary[$"Candy {i}"];
                }
            }

            //Finding names of candies with min price
            string names = "";
            string cache = "";
            bool flag = true;
            for (int i = 1; i <= 10; i++) {
                if (minprice == dictionary[$"Candy {i}"]) {
                    if (flag) {
                        names += $"Candy {i}";
                        flag = false;
                    } else {
                        cache = $" и Candy {i}";
                    }
                }
            }
            Console.WriteLine($"\nСамые дешёвые конфеты - {names + cache}");
        }
    }
    internal class SeventhPractice {
        internal static void FirstNumber() {
            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine($"\n{Name} {Surname}");
        }
        internal static void SecondNumber() {
            Console.WriteLine("Введите название футбольного клуба");
            string club = Console.ReadLine();
            Console.WriteLine($"\nВ названии {club.Length} символа/ов");
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();

            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nБуквы слова начиная с {n} и заканчивая {m} включительно:");
            Console.WriteLine($"{word.Substring(n - 1, m - n + 1)}");
        }
        internal static void FourthNumber() {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            Console.WriteLine(word.Substring(word.Length / 2, word.Length / 2) + word.Substring(0, word.Length / 2));
        }
        internal static void FifthNumber() {
            Console.WriteLine("Введите предложение");
            string word = Console.ReadLine();
            Console.WriteLine("\nКаждый 3-ий символ:");
            for (int i = 2; i < word.Length; i += 3) {
                Console.WriteLine(word.Substring(i, 1));
            }
        }
        internal static void SixthNumber() {
            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine($"\nСамое длинное слово: {words.Max()}");
        }
    }
    internal class EighthPractice {
        internal static void FirstNumber() {
            Directory.CreateDirectory("test");
            File.AppendAllText("test/test.txt", "Hello, World!");
        }
        internal static void SecondNumber() {
            Console.WriteLine("Введите путь до файла");
            string path = Console.ReadLine();
            if (File.Exists(path)) {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++) 
                    if (lines[i].Contains(":")) 
                        Console.WriteLine($"Длина {i+1} строки: {lines[i].Length} символ/а/ов");
            } else Console.WriteLine("Такого файла нет.");
        }
        internal static void ThirdNumber() {
            Console.WriteLine("Введите путь до файла");
            string path = Console.ReadLine();
            if (File.Exists(path)) {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                    if (line.StartsWith("Т")) Console.WriteLine(line);
            } else Console.WriteLine("Такого файла нет.");
        }
        internal static void FourthNumber() {
            Console.WriteLine("Введите путь до файла");
            string path = Console.ReadLine();
            if (File.Exists(path)) {
                File.Copy(path, path.Insert(path.Length - 4, "Copy")); 
                Console.WriteLine("\nПуть до файла:\n" + path.Insert(path.Length - 4, "Copy"));
            } else Console.WriteLine("Такого файла нет.");
        }
    }
    internal class NinethPractice {
        internal static void FirstNumber() {
            try {
                Console.Write("Введите вес картофеля в кг: "); double potatoes = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВведите вес огурцов в кг: "); double cucumbers = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nВведите вес томатов в кг: "); double tomatoes = Convert.ToDouble(Console.ReadLine());
                if (potatoes + cucumbers + tomatoes <= 10) {
                    Console.WriteLine("Выдержат");
                } else Console.WriteLine("Не выдержат");
            } catch (FormatException) {
                Console.WriteLine("Это явло не вес, весы не были к такому готовы.");
            }
        }
        internal static void SecondNumber() {
            try {
                double moneyFirst = 1000;
                double moneySecond = 1000;
                Console.Write("N% годовых 1-ого банка: "); double n = Convert.ToDouble(Console.ReadLine());
                if (n >= 3) {
                    Console.WriteLine("Никогда");
                    Thread.Sleep(2000);
                    Environment.Exit(1);
                }
                for (int years = 0; true; years++,
                                          moneyFirst += moneyFirst / 100 * n,
                                          moneySecond += moneyFirst / 30) {
                    if (moneyFirst + 100 <= moneySecond) {
                        Console.WriteLine($"Через {years} год/года/лет");
                        break;
                    }
                }
            } catch (FormatException) {
                Console.WriteLine("Гуриев был бы в шоке");
            }
}
        internal static void ThirdNumber() {
            try {
                Console.Write("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] arr = new double[n];
                Random rnd = new Random();

                Console.WriteLine("\nВаш массив:\n");
                for (int i = 0; i < n; i++) {
                    arr[i] = Math.Round(rnd.NextDouble() * 10, 2); Console.Write(arr[i] + " ");
                }
            } catch (FormatException) {
                Console.WriteLine("\nВведите целочисленное значение.");
            } catch (OverflowException) {
                Console.WriteLine("\nА ещё положительные числа, pls.");
            }
        }
        internal static void FourthNumber() {
            try {
                Console.Write("Введите слово: ");
                string word = Console.ReadLine();
                Console.Write("Введите индекс начала подстроки(m): ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер конца подстроки(n): ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n" + word.Substring(m, n - m));
            } catch (FormatException){
                Console.WriteLine("\nТак нельзя введите нормальное число");
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine("\nТак тоже, в программе делается n - m");
            }
        }
    }
    internal class TenthPractice {
        internal static void FirstNumber() {
            Console.WriteLine($"Сейчас: {DateTime.Now.ToShortDateString()}" +
                              $"\nДата через 5 лет 3 дня: {DateTime.Now.AddDays(3).AddYears(5).ToShortDateString()}");
        }
        internal static void SecondNumber() {
            Console.WriteLine($"Сейчас: {DateTime.Now}" +
                              $"\nДата и время 6 часов и 5 минут назад: {DateTime.Now.AddHours(-6).AddMinutes(-5)}");
        }
        internal static void ThirdNumber() {
            try {
                Console.Write("Введите дату: "); DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"\nCколько дней прошло с этой даты с начала года этой даты: {date.DayOfYear}");
            } catch (FormatException) {
                Console.WriteLine("Кажется Майя были правы...");
            }
        }
        internal static void FourthNumber() {
            try {
                Console.Write("Введите дату: "); DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(date.ToString("d"));
            } catch (FormatException) {
                Console.WriteLine("\nИли не были...\n" +
                                  "Интересный факт: попробуйте ввести только время");
            }
        }
    }
    internal class EleventhPractice {
        internal static void FirstNumber() {
            Console.WriteLine("Введите предложение:"); string sentence = Console.ReadLine();
            if (Regex.IsMatch(sentence, "программа", RegexOptions.Compiled | RegexOptions.IgnoreCase)) Console.WriteLine("\nВ предложении ЕСТЬ слово “программа”");
            else Console.WriteLine("\nВ предложении НЕТ слова “программа”");
        }
        internal static void SecondNumber() {
            Console.Write("Введите дату в формате ДД.ММ.ГГГГ : "); string date = Console.ReadLine();
            Regex datePattern = new Regex(@"^(\d{2})\.(\d{2})\.(\d{4})$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (datePattern.Match(date).Success) Console.WriteLine($"\nДата в формате день:месяц:год : {Regex.Replace(date, "\\.", ":")}");
            else Console.WriteLine("\nНеверный формат даты");
        }
        internal static void ThirdNumber() {
            Console.Write("Введите ip v6: ");
            string ip = Console.ReadLine();
            Regex regex = new Regex(@"^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$" ,
                                    RegexOptions.Compiled);
            if (regex.IsMatch(ip)) Console.Write("IP-адрес правильный");
            else Console.Write("IP-адрес неправильный");
        }
    }
    internal class TwelfthPractice {
        internal static void FirstNumber() {
        }
        internal static void SecondNumber() {
        }
        internal static void ThirdNumber() {
        }
        internal static void FourthNumber() {
        }
        internal static void FifthNumber() {
        }
    }
}
