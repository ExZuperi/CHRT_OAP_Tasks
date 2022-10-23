﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
            First_Practice.fifth_num();
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

            if (maxNum == a) {
                if (a == b) {
                    if (a == c) {
                        if (a == d) {
                            Console.WriteLine($"Рост всех учеников одинаков - {a}");
                        } else {
                            Console.WriteLine($"Рост всех учеников одинаков, кроме ученика d, рост самых высоких - {a}");
                        }
                    } else if (a == d) {
                        Console.WriteLine($"Рост всех учеников одинаков, кроме ученика c, рост самых высоких - {a}");
                    } else {
                        Console.WriteLine($"Самые рослые ученики a и b, их рост - {a}");
                    }
                } else if (a == c) {
                    if (a == d) {
                        Console.WriteLine($"Рост всех учеников одинаков, кроме ученика b, рост самых высоких - {a}");
                    } else {
                        Console.WriteLine($"Самые рослые ученики a и c, их рост - {a}");
                    }

                } else if (a == d) {
                    Console.WriteLine($"Самые рослые ученики a и d, их рост - {a}");
                } else {
                    Console.WriteLine($"Самый рослый ученик - ученик a, его рост - {a}");
                }
            } else if (maxNum == b) {
                if (b == c) {
                    if (b == d) {
                        Console.WriteLine($"Рост всех учеников одинаков, кроме ученика a, рост самых высоких - {b}");
                    }
                } else if (b == d) {
                    Console.WriteLine($"Самые рослые ученики - ученик b и d их рост - {b}");
                } else {
                    Console.WriteLine($"Самые рослый ученики b, его рост - {b}");
                }
            } else if (maxNum == c) {
                if (c == d) {
                    Console.WriteLine($"Самые рослые ученики - ученик c и d их рост - {c}");
                } else {
                    Console.WriteLine($"Самый рослый ученик - ученик c, его рост - {c}");
                }
            } else {
                Console.WriteLine($"Самый рослый ученик - ученик d, его рост - {d}");
            }

            Console.ReadKey();
        }
        internal static void second_num() {
            Console.WriteLine("Введите радиус круга");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость волка");
            double wolf_speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость шапочки");
            double girl_speed = Convert.ToDouble(Console.ReadLine());

            if ((wolf_speed <= 0) || (girl_speed <= 0)) {
                Console.WriteLine("Cкорость не м.б. <= 0");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            } if ((R <= 0)) {
                Console.WriteLine("Да Вы просто издеваетесь. Ненавижу бессмысленные проверки");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }

            if ((R * Math.PI) / girl_speed < R * 2 / wolf_speed) {
                Console.WriteLine("Шапочка быстрее");
            } else if ((R * Math.PI) / girl_speed == R * 2 / wolf_speed) {
                Console.WriteLine("Они придут в точку одновременно");
            } else {
                Console.WriteLine("Волк быстрее");
            }
            Console.ReadKey();
        }
        internal static void third_num() {
            Console.WriteLine("Введите площадь круга");
            int circle_S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь квадрата");
            int square_S = Convert.ToInt32(Console.ReadLine());

            if ((circle_S < 0) || (square_S < 0)) {
                Console.WriteLine("Ха-ха-ха");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            } if (2 * Math.Sqrt(circle_S / Math.PI) <= Math.Sqrt(square_S)) {
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
                    Console.WriteLine("Числа одинаковы");
                }
            } else {
                Console.WriteLine("Число не двузначное");
            }
        }
        internal static void fifth_num() {
            Console.WriteLine("Введите аргумент\n" +
                              "a - расчет площади квадрата\n" +
                              "b - расчёт площади треугольника\n" +
                              "c - расчёт площади прямоугольника\n" +
                              "d - расчёт площади круга");
            string some = Convert.ToString(Console.ReadLine());

            if (some == "a") { // We may use switch-case construction like that: switch(some){ case "a": ...brake}. But... our topic is if constructions
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
            Console.WriteLine("Введите n >= 2");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2) {
                Console.WriteLine("НАПОМНЮ ЧИСЛО ДОЛЖНО БЫТЬ БОЛЬШЕ 2");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }

            for (int i = n; i >= 2; i--) {
                rez += 1F / i;
            }
            Console.WriteLine(rez);
        }
        internal static void fourth_num() {
            for (int i = 100; i <= 200; i += 7) {
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
                if (num <= 5) {
                    Console.WriteLine("More than 5 pls");
                }

                if (num == 22) {
                    flag = false;
                    continue;
                }

                if (num == 0) {
                    Console.WriteLine("La commedia è finita \n" +
                                      "Program was stopped, thx for using");
                    break;
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
            int[] mass = new int[10];
            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < 10; i++) {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++) {
                Console.Write(mass[i] + " ");
            }
        }
        internal static void second_num() {
            int[] mass = new int[10];
            Console.WriteLine("Введите первый член прогрессии");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите разность");
            int p = Convert.ToInt32(Console.ReadLine());

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
            int[] mass = new int[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Math.Abs(mass[i]);
            }

            Console.WriteLine("Ваш abs массив - ");
            for (int i = 0; i < mass.Length; i++) {
                Console.Write(mass[i] + " ");
            }
        }
        internal static void fourth_num() {
            Console.WriteLine("Введите размер массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];

            Console.WriteLine("Введите элементы массива через Enter");
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());

            int s_twenty = 0;
            int s_a = 0;
            for (int i = 0; i < mass.Length; i++) {
                if (mass[i] <= 20) {
                    s_twenty += mass[i];
                }
            }

            for (int i = 0; i < mass.Length; i++) {
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
                Console.WriteLine("\n На брабане буква: ");
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
}