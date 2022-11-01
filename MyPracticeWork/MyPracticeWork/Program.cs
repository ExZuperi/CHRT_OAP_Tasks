using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyPracticeWork
{
    internal class Program
    {
        static void Main(string[] args) {
            Sixth_Practice.fourth_num();
            Console.ReadKey();
        }
    }
    internal class First_Practice {
        internal static void first_num() {
            Console.WriteLine("Введите сторону a > 0");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b > 0");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь - {a * b}, периметр - {(a + b) * 2}");
        }
        internal static void second_num() {
            Console.WriteLine("Введите скорость первого авто");
            double First_Speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость второго авто");
            double Second_Speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальное расстояние между машинами");
            double way = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите T (Количество часов)");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Расстояни между ними через {hours} час/а - {way + First_Speed * hours + Second_Speed * hours} км");
        }
        internal static void third_num() {
            Console.WriteLine("Введите радиус шара >= 0");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Объём шара - {4F / 3F * Math.PI * (Math.Pow(R, 3))}");
        }
        internal static void fourth_num() {
            Console.WriteLine("Введите x - не равный 0");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Z = {(x + ((2 + y) / (x * x))) / (y + (1 / (Math.Sqrt(Math.Pow(x, 2) + 10))))}");
        }
        internal static void fifth_num() {
            Console.WriteLine("Введите количество секунд");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Полных часов прошло - {n / 60 / 60}");
        }
    }
    internal class Second_Practice {
        internal static void first_num() {
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
        internal static void second_num() {
            Console.WriteLine("Введите радиус круга");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость волка");
            double wolf_speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость шапочки");
            double girl_speed = Convert.ToDouble(Console.ReadLine());

            if ((wolf_speed <= 0) || (girl_speed <= 0)) {
                throw new ArgumentException($"Скорость не мб <= 0, ваша - {wolf_speed} {girl_speed}");
            } if ((R < 0)) {
                throw new ArgumentException($"R не мб < 0, ваш - {R}");
            }

            if ((R * Math.PI) / girl_speed < R * 2 / wolf_speed) {
                Console.WriteLine("Шапочка быстрее");
            } else if ((R * Math.PI) / girl_speed == R * 2 / wolf_speed) {
                Console.WriteLine("Они придут в точку одновременно");
            } else {
                Console.WriteLine("Волк быстрее");
            }
        }
        internal static void third_num() {
            Console.WriteLine("Введите площадь круга");
            int circle_S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь квадрата");
            int square_S = Convert.ToInt32(Console.ReadLine());

            if ((circle_S < 0) || (square_S < 0)) {
                throw new ArgumentException($"Показатели не мб < 0, ваши - {circle_S} {square_S}");
            } 
            if (2 * Math.Sqrt(circle_S / Math.PI) <= Math.Sqrt(square_S)) {
                Console.WriteLine("Уместится");
            } else {
                Console.WriteLine("Нет");
            }
        }
        internal static void fourth_num() {
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
        internal static void fifth_num() {
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
        internal static void sixth_num() {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
    internal class Third_Practice {
        internal static void first_num() {
            for (int i = 2; i <= 200; i += 2) {
                Console.Write(i + " ");
            }
        }
        internal static void second_num() {
            for (int i = 10; i <= 150; i += 10) {
                Console.WriteLine(i);
            }
        }
        internal static void third_num() {
            float rez = 0F;
            Console.WriteLine("Введите целое n >= 2");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2) {
                throw new ArgumentException($"Число должно быть >= 2. Ваше - {n}");
            }

            for (int i = n; i >= 2; i--) {
                rez += 1F / i;
            }
            Console.WriteLine(rez);
        }
        internal static void fourth_num() {
            for (int i = 107; i <= 200; i += 7) {
                Console.WriteLine("Шар под номером - " + i);
            }
        }
        internal static void fifth_num() {
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
        internal static void sixth_num() {
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
    internal class Fourth_Practice {
        internal static void first_num() {
            double[] mass = new double[10];
            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < 10; i++) {
                mass[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++) {
                Console.Write(mass[i] + " ");
            }
        }
        internal static void second_num() {
            double[] mass = new double[10];
            Console.WriteLine("Введите первый член прогрессии");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите разность");
            double p = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < mass.Length; i++) {
                mass[i] = a + i * p;
            }

            Console.WriteLine("Ваш массив - ");
            for (int i = 0; i < mass.Length; i++) {
                Console.Write(mass[i] + " ");
            }
        }
        internal static void third_num() {
            Console.WriteLine("Введите размер массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("Ваш abs массив - ");
            for (int i = 0; i < mass.Length; i++) {
                Console.Write(mass[i] + " ");
            }
        }
        internal static void fourth_num() {
            Console.WriteLine("Введите размер массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Введите а");
            double a = Convert.ToDouble(Console.ReadLine());

            double s_twenty = 0;
            double s_a = 0;

            for (int i = 0; i < mass.Length; i++) {
                if (mass[i] <= 20) {
                    s_twenty += mass[i];
                }
                if (mass[i] > a) {
                    s_a += mass[i];
                }
            }
            Console.WriteLine($"Сумма элементов <= 20 - {s_twenty}");
            Console.WriteLine($"Сумма элементов > a({a}) - {s_a}");
        }
        internal static void fifth_num() {
            string word = "копол";
            string secret_word = "*****";
            // TODO: Make random generation of word, with parsing of site
            bool flag = false;

            Console.WriteLine("Играем в виселицу!");
            Console.Write("Такс... Слово выбрано, поехали.");

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("\n На барабане буква: ");
                char letter = Convert.ToChar(Console.Read());
                for (int j = 0; i < word.Length; i++) {
                    if (word[j] == letter) {
                        secret_word = secret_word.Remove(i, 1).Insert(i, letter.ToString());
                    }
                }
                if (flag) {
                    Console.WriteLine($"ОТКРОЙТЕ БУКВУ {letter} - {secret_word}");
                    i--;
                    continue;
                } else {
                    switch (i) {
                        case 0:
                            Console.WriteLine("----" +
                                              "    o" +
                                              "|   |" +
                                              "|   O" +
                                              "|   ");
                            break;
                        case 1:
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.WriteLine();
                            break;

                    }
                }
            }
        }
    }
    internal class Fifth_Practice {
        internal static void first_num() {
            int[,] mass = new int[5, 4];
            Console.WriteLine("Выберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("Введите 20 значений через Enter");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 4; j++) {
                            mass[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 4; j++) {
                            mass[i, j] = rnd.Next(10);
                            Console.Write(mass[i, j] + " ");
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
                    if (mass[i, j] < 5) {
                            mass[i, j] = 111;
                    }
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        internal static void second_num() {
            int[,] mass = new int[4, 5];
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
                            mass[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 4; i++) {
                        for (int j = 0; j < 5; j++) {
                            mass[i, j] = rnd.Next(11);
                            Console.Write(mass[i, j] + " ");
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
                    if (mass[i, j] == 10) {
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
        internal static void third_num() {
            double[,] mass = new double[5, 5];
            Console.WriteLine("Выберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {
                case 1:
                    Console.WriteLine("Введите 25 значений через Enter");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 5; j++) {
                            mass[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    Console.WriteLine("Ваш первоначальный rnd массив - ");
                    for (int i = 0; i < 5; i++) {
                        for (int j = 0; j < 5; j++) {
                            mass[i, j] = Math.Round(rnd.NextDouble() + 0.01 * 100, 2);
                            Console.Write(mass[i, j] + " ");
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
                    Console.Write($"{Math.Round(Convert.ToDouble(mass[i, j]) / mass[i, 0], 2)} ");
                }
                Console.WriteLine();
            }

        }
        internal static void fourth_num() {
            Console.WriteLine("Введите размер квадратного массива (n*n) >= 1");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] mass = new double[n, n];
            Console.WriteLine("\nВыберите способ заполнения массива:\n" +
                              "'1' - С клавиатуры\n" +
                              "'2' - Через Random");
            int some = Convert.ToInt32(Console.ReadLine());

            switch (some) {

                case 1:
                    Console.WriteLine($"\nВведите {n * n} значений через Enter");
                    for (int i = 0; i < n; i++) {
                        for (int j = 0; j < n; j++) {
                            mass[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                break;

                case 2:
                    Random rnd = new Random(100);
                    Console.WriteLine("\nВаш первоначальный rnd массив - ");
                    for (int i = 0; i < n; i++) {
                        for (int j = 0; j < n; j++) {
                            mass[i, j] = Math.Round((rnd.NextDouble() - 0.5) * 100, 2);
                            Console.Write(mass[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                break;
               
                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            //Finding Max Value in mass
            double maxNum = mass[0, 0];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mass[i, j] >= maxNum) {
                        maxNum = mass[i, j];
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
                    if ((mass[i, j] >= 0) && (mass[i, j] <= minPol)) {
                        minPol = mass[i, j];
                    }
                }
            }
            Console.WriteLine($"\nМинимальное положительное число - {minPol}");

            //Making copy of array
            double[,] reversedMass = new double[n,n];
            Array.Copy(mass, reversedMass, n*n);

            //Finding column and line with minNum 
            int line = 0;
            int column = 0;
            for (int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if (mass[i, j] == minPol) {
                        line = i;
                        column = j;
                        i = n; //Breaking 2 fors
                    }
                }
            }

            //Reversing elements
            for (int i = 0; i < n; i++) {
                reversedMass[i, column] = mass[line, i];
                reversedMass[line, i] = mass[i, column];
            }

            //Printing reversedMass
            Console.WriteLine("\nМассив с обменянными строкой и столбцом");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(reversedMass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Внимание! Сначала меняется строка, а затем столбец. Возможны наложения");
        }
    }
    internal class Sixth_Practice {
        internal static void first_num() {
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
        internal static void second_num() {
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
        internal static void third_num() {
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] mass = new double[n];
            Stack stck = new Stack();

            Console.WriteLine("\n'1' - Ввод чисел через клавиатуру\n" +
                              "'2' - Ввод чисел через Random");
            int some = Convert.ToInt32(Console.ReadLine());
            switch (some) {
                case 1:
                    Console.WriteLine("Вводите числа через Enter");
                    for (int i = 0; i < n; i++) {
                        mass[i] = Convert.ToDouble(Console.ReadLine());
                        if (i % 2 == 0) {
                            mass[i] *= 2;
                        } else {
                            mass[i] -= 1;
                        }
                        stck.Push(mass[i]);
                    }
                    break;

                case 2:
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++) {
                        mass[i] = Math.Round(rnd.NextDouble() * 100, 2);
                        Console.Write(mass[i] + " ");
                        if (i % 2 == 0) {
                            mass[i] *= 2;
                        } else {
                            mass[i] -= 1;
                        }
                        stck.Push(mass[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine("\n\nПосле умножения и вычитания:\n");
            for (int i = 0; i < mass.Length; i++) {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nВведите 10 чисел которые нужно добавить через Enter");
            for (int i = 0; i < 10; i++) {
                stck.Push(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine("\nВаш стек - ");
            for (int i = 0; i < 10 + n; i++) {
                Console.Write(stck.Pop() + " ");
            }


        }
        internal static void fourth_num() {
            Dictionary<string, double> dct =
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
                        dct.Add($"Candy {i}", Convert.ToDouble(Console.ReadLine()));
                    }
                    break;

                case 2:
                    for (int i = 1; i <= 10; i++) {
                        dct.Add($"Candy {i}", Math.Round((rnd.NextDouble() + 0.1) * 100, 2));
                        Console.WriteLine(dct[$"Candy {i}"]);
                    }
                    break;

                default:
                    Console.WriteLine("Неправильный выбор");
                    Environment.Exit(1);
                    break;
            }

            //Finding min price
            double min_price = dct["Candy 1"];
            for (int i = 1; i <= 10; i++) {
                if (min_price > dct[$"Candy {i}"]) {
                    min_price = dct[$"Candy {i}"];
                }
            }

            //Finding names of candies with min price
            string names = "";
            string cache = "";
            bool flag = true;
            for (int i = 1; i <= 10; i++) {
                if (min_price == dct[$"Candy {i}"]) {
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
}

//TODO: Make try-catch
