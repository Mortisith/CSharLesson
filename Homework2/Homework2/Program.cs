using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Homework2
{
    internal class Program
    {
        #region первое задание
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Написать метод, возвращающий минимальное из трёх чисел");
            Console.WriteLine("*******************************************************");
            Console.Clear();
            Console.WriteLine("Введите данные для сравнения:");
            Console.Write("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            int minNumber = 0;
            if (b > a && c > a)
            {
                minNumber = a;
            } if (b < a && b < c)
            {
                minNumber = b;
            } if (c < a && c < b)
            {
                minNumber = c;
            }

            Console.Clear();
            Console.WriteLine($"Наименьшее из чисел - {minNumber}");
            Console.ReadLine();

        }
        #endregion

        #region второе задание
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Написать метод подсчета количества цифр числа.");
            Console.WriteLine("**********************************************");

            Console.Write("Для выполнения операции введите число: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            
           while (number != 0)
            {
                count++;
                number = number / 10;
            }
           Console.WriteLine($"Колличество чисел в числе - {count}");
           Console.ReadLine();

        }
        #endregion

        #region третье задание
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Подсчитать сумму всех нечетных положительных чисел.");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Ведите число\n Для завершения введите 0");
            int summ = 0;
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    summ = summ + number;
                }

            } while (number != 0);


            Console.WriteLine($"Сумма введеных нечетных чисел равна: {summ}");
            Console.ReadLine();

        }
        #endregion

        #region четвертое задание
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Mетод проверки логина и пароля.");
            Console.WriteLine("*******************************");

            string login = "root";
            string password = "GeekBrains";
            int counter = 1;

            while (counter <= 3)
            {
                Console.Write("Введите логин и пароль: ");
                string userLogin = Console.ReadLine();
                string userPassword = Console.ReadLine();
                if (login == userLogin && password == userPassword)
                {
                    Console.WriteLine("Авторизация прошла успешно");
                    break;
                }
                else
                {
                    if (counter == 3)
                    {
                        Console.WriteLine("К сожалению, вы исчерпали все попытки");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Логин или пароль неверный, пожалуйста, попробуйте снова");
                        counter++;
                    }
                }
            }

        }
        #endregion

        #region пятое задание
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Расчет оптимального ИМТ");
            Console.WriteLine("***********************");

            Console.WriteLine("Добрый день. Здесь вы сможете вычеслить индекс массы тела. Пожалуйста, введите данные:");
            Console.Write("Вес, в киллограмах: ");
            double mass = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Рост, в метрах: ");
            double growing = double.Parse(Console.ReadLine());
            Console.Clear();
            double optimalindex;
            int counter = 0;

            double index = mass / Math.Pow(growing, 2);
            if (index <= 19)
            {
                Console.WriteLine($"Ваш ИМТ: {index:F2}\n У Вас недостаточная масса тела");
                do
                {
                    optimalindex = (mass + 1) / Math.Pow(growing, 2);
                    index = optimalindex;
                    counter++;
                    mass++;

                } while (index < 20);
                Console.WriteLine("Вам необходимо набрать: {0} киллограм", counter);

            }
            if (index > 21 && index < 26)
            {
                Console.WriteLine($"Ваш ИМТ: {index:F2}\n Ваша масса тела в норме, так держать");
            }
            if (index > 26)
            {
                Console.WriteLine($"Ваш ИМТ: {index:F2}\n У Вас избыточная масса тела");
                do
                {
                    optimalindex = (mass - 1) / Math.Pow(growing, 2);
                    index = optimalindex;
                    counter++;
                    mass--;

                } while (index > 25);
                Console.WriteLine("Вам необходимо сбросить: {0} киллограм", counter);
            }
            Console.ReadLine();

        }
        #endregion

        #region шестое задание
        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.");
            Console.WriteLine("*****************************************************************************************");

            DateTime start = DateTime.Now;
                    
            int goodNumberCounter = 0;

            int NumberSumm(int n) // сумма цифр числа
            {
                
                int startN = n;
                int s = 0;
                while (n != 0)
                {
                    s = s + n % 10;
                    n = n / 10;
                }
                if (startN%s == 0)
                {
                    goodNumberCounter++;
                }
                return goodNumberCounter;

            }


            for (int i = 1; i <= 1000000000; i++)
            {
                int sc = NumberSumm(i);
                if (i == 1000000000)
                {
                    Console.WriteLine(goodNumberCounter);
                }

            }
            DateTime finish = DateTime.Now;
            Console.WriteLine("Затраченное время: " + (finish - start));

        }
        #endregion

        #region седьмое задание
        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).");
            Console.WriteLine("*****************************************************************************");


            Console.Write("Введите меньшее число:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите большее число:");
            int b = int.Parse(Console.ReadLine());
            int summ = 0;
            SeriesNumber(a, b);

            void SeriesNumber(int x, int y)
            {
                Console.Write("{0,2} ", x);
                if (x < y) SeriesNumber(x + 1, y);
                summ = summ + x;
            }
            Console.WriteLine($"\n Сумма чисел: {summ}");
        }
        #endregion



        static void Main(string[] args)
        {
            StudentHelper.PrintFIO(2, "Гончаренко Людмила");

            bool f = true;

            while (f)
            {
                Console.WriteLine("Домашняя работа по теме: Управляющие конструкции");
                Console.WriteLine("************************************************");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("6 -> Задача 6");
                Console.WriteLine("7 -> Задача 7");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("*********************************\n");

                Console.Write("Пожалуйста,введите номер задачи для проверки: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.Clear();
                        Console.SetCursorPosition(45, 5);
                        Console.WriteLine("Спасибо за уделенное время");
                        Console.ReadKey();
                        f = false;
                        break;

                    case 3:
                        Console.Clear();
                        Task3();
                        Console.ReadLine();

                        break;

                    case 2:
                        Console.Clear();
                        Task2();
                        Console.ReadLine();

                        break;

                    case 1:
                        Console.Clear();
                        Task1();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Clear();
                        Task4();
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear();
                        Task5();
                        Console.ReadLine();
                        break;


                    case 6:
                        Console.Clear();
                        Task6();
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.Clear();
                        Task7();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
