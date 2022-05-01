using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Homework3Goncharenko
{
    #region Класс комплексных чисел
    /// <summary>
    /// Класс комплексного числа
    /// </summary>
    class ComplexClass
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public double Re
        {
            get
            {
                return re;
            }

            set
            {



                re = value;
            }

        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            //if (im == 0)
            //{
            //    throw new Exception("На ноль делить нельзя!");
            //}
            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass(re + x.re, im + x.im);
            //complexRes.re = re + x.re;
            //complexRes.im = im + x.im;
            return complexRes;
        }
        //public static ComplexClass Division (ComplexClass a, ComplexClass b)
        //{
        //    ComplexClass complexRes = new ComplexClass(a.re - b.re, a.im - b.im);
        //    return complexRes;
        //}

        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re + b.re, a.im + b.im);
            //complexRes.re = a.re + b.re;
            //complexRes.im = a.im + b.im;
            return complexRes;
        }
        public static ComplexClass Subtraction(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass(a.re - b.re, a.im - b.im);
            return complexRes;
        }

        public static ComplexClass Multiplication(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexRes = new ComplexClass((a.re * b.re), (a.im * b.im));
            return complexRes;
        }
     


        public override string ToString()
        {
            //return base.ToString();
            return $"{re} + {im}i";
        }


    }
    #endregion


    #region класс дробей
    /// <summary>
    /// Класс дробей
    /// </summary>
    class Fraction
    {
        /// <summary>
        /// числитель и знаменатель
        /// </summary>
        private int numeration;
        private int denominator;

        
        /// <summary>
        /// Свойства(на чтение и запись числителя)
        /// </summary>
        public int Numeration
        {
            get
            {
                return numeration; 
            }

            set
            {

                numeration = value;
            }
             
        }
        /// <summary>
        /// Свойства(на чтние ии запись знаменателя)
        /// </summary>
        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                denominator = value;
            }
        }
        /// <summary>
        /// Инструмент запуска
        /// </summary>
        public Fraction()
        {

        }
        /// <summary>
        /// Инстумент вывода класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
          return $"{numeration}/{denominator}";
        }
        /// <summary>
        /// Инициализация дроби
        /// </summary>
        /// <param name="numeration"> числитель </param>
        /// <param name="denominator"> знаменатель </param>
        /// <exception cref="Exception"> Проверка корректного ввода</exception>
        public Fraction (int numeration, int denominator)
        {
            if (denominator == 0)
            {
               throw new Exception("На ноль делить нельзя!");
            }
            this.numeration = numeration;
            this.denominator = denominator;
        }
        /// <summary>
        /// Сокращение дроби
        /// </summary>
        /// <param name="a">общий делитель</param>
        /// <returns></returns>
        public static int NOD( Fraction a)
        {
           int y = a.Denominator;
           int z = a.Numeration;
           int nodres = y - z; 
           if (nodres < 0)
            {
                nodres = 2 * nodres + nodres;
                return nodres;
            }
            return nodres;
        }
        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="x"> первая дробь</param>
        /// <param name="y"> вторая дробь</param>
        /// <returns></returns>
        public static Fraction Plus(Fraction x, Fraction y)
        {
            Fraction fractionRes = new Fraction( (y.numeration*x.denominator) + (x.numeration * y.denominator), y.denominator * x.denominator);
            int a = NOD(fractionRes);
            fractionRes = new Fraction((fractionRes.numeration / a), (fractionRes.denominator / a)); 
            return fractionRes;
        }
        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="x"> первая дробь</param>
        /// <param name="y"> вторая дробь</param>
        /// <returns></returns>
        public static Fraction Subtraction(Fraction x, Fraction y)
        {
            Fraction fractionRes = new Fraction((y.numeration * x.denominator) - (x.numeration * y.denominator), y.denominator * x.denominator);
            int a = NOD(fractionRes);
            fractionRes = new Fraction((fractionRes.numeration / a), (fractionRes.denominator / a));
            return fractionRes;
        }
        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="x"> первая дробь</param>
        /// <param name="y"> вторая дробь</param>
        /// <returns></returns>
        public static Fraction Multiplication (Fraction x, Fraction y)
        {
            Fraction fractionRes = new Fraction (y.numeration * x.numeration , y.denominator * x.denominator);
            int a = NOD(fractionRes);
            fractionRes = new Fraction((fractionRes.numeration / a), (fractionRes.denominator / a));
            return fractionRes;
        }
        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="x"> первая дробь</param>
        /// <param name="y"> вторая дробь</param>
        /// <returns></returns>
        public static Fraction Division(Fraction x, Fraction y)
        {
            Fraction fractionRes = new Fraction(x.numeration * y.denominator, y.numeration * x.denominator);
            int a = NOD(fractionRes);
            fractionRes = new Fraction((fractionRes.numeration / a), (fractionRes.denominator / a));
           
            return fractionRes;
        }
    }
    #endregion


    internal class Program


    {
        static void Main(string[] args)
        {

            StudentHelper.PrintFIO(3, "Гончаренко Людмила");

            bool f = true;

            while (f)
            {
                Console.Clear();
                Console.WriteLine("Домашняя работа по теме: Методы. От структур к объектам. Исключения.");
                Console.WriteLine("************************************************");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
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
                    #region третье задание
                    case 3:
                        Console.Clear();
                        Console.Write("Действия с дробями. Введите числитель первого числа: ");
                        int numeration1 = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель первого числа: ");
                        int denominator1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите числитель второго числа: ");
                        int numeration2 = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель второго числа: ");
                        int denominator2 = int.Parse(Console.ReadLine());
                        Fraction newnumber1 = new Fraction (numeration1, denominator1);
                        Fraction newnumber2 = new Fraction (numeration2, denominator2);
                        bool l = true;
                        while (l)
                        {
                            Console.Write("Какое действие Вы хотите выполнить:\n 1---> сложение\n 2---> вычитание\n 3---> умножение\n 4---> деление\n 0--->завершение действий");
                            Console.WriteLine();
                            int donumber = int.Parse(Console.ReadLine());
                            switch (donumber)
                            {
                                case 1:
                                    Fraction newnumber3 = Fraction.Plus(newnumber1, newnumber2);
                                    Console.WriteLine($"Результат действия: {newnumber3}");
                                    break;
                                
                                case 0:
                                    l = false;
                                    Console.WriteLine("Завершение вычисления");
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                                    break;
                                    case 2:
                                    Fraction newnumber4 = Fraction.Plus(newnumber1, newnumber2);
                                    Console.WriteLine($"Результат действия: {newnumber4}");
                                    break;
                                    case 3:
                                    Fraction newnumber5 = Fraction.Multiplication(newnumber1, newnumber2);
                                    Console.WriteLine($"Результат действия: {newnumber5}");
                                    break;
                                case 4:
                                    Fraction newnumber6 = Fraction.Division(newnumber1, newnumber2);
                                    Console.WriteLine($"Результат действия: {newnumber6}");
                                    //if (newnumber6.numeration > newnumber6.denominator)
                                    //{
                                    //    double ress = newnumber6.numeration / newnumber6.denominator; как можно из одного типа данных перевести в другой?
                                    //    return ress;
                                    //}
                                    break;
                            }
                        }
                        Console.ReadLine();
                        break;
#endregion

                    case 2:
                        #region задание 2
                        Console.Clear();
                        int summ = 0;
                        while (number != 0)
                        {
                            Console.WriteLine("Пожалуйста введите число:\n Для завершения введите 0.");

                            if (int.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine($"Вы ввели число: {number}");
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели некорректное число.");
                            }
                            if (number%2 != 0)
                            {
                                summ = summ + number;
                            } if (number < 0)
                            {
                                Console.WriteLine("Нужно ввести положительное число. Попробуйте еще раз");
                            }
                            if (number == 0)
                            {
                                Console.WriteLine($"Завершение подсчета\n Сумма введеных нечетных чисел равна: {summ}");
                                break;
                            }                            
                        
                        }

                        Console.ReadLine();
                        break;
#endregion
                    case 1:
                         #region задание 1
                        Console.Clear();
                        Console.Write("Действия с комплексными числами. Введите действительную часть первого числа: ");
                        double re1 = double.Parse(Console.ReadLine());
                        Console.Write("Мнимую часть первого числа: ");
                        double im1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите действительную часть второго числа: ");
                        double re2 = double.Parse(Console.ReadLine());
                        Console.Write("Мнимую часть второго числа: ");
                        double im2 = double.Parse(Console.ReadLine());
                        ComplexClass number1 = new ComplexClass(re1, im1);
                        ComplexClass number2 = new ComplexClass(re2, im2);
                        bool m = true;
                        while (m)
                        {
                            Console.Write("Какое действие Вы хотите выполнить:\n 1---> сложение\n 2---> вычитание\n 3---> умножение\n 0--->завершение действий");
                            int donumber = int.Parse(Console.ReadLine());
                            switch (donumber)
                            {
                                case 1:
                                    ComplexClass number3 = ComplexClass.Plus(number1, number2);
                                    Console.WriteLine($"Результат действия: {number3}");
                                    break;
                                    case 2:
                                    ComplexClass number4 = ComplexClass.Subtraction (number1, number2);
                                    Console.WriteLine ($"Результат действия: {number4}");
                                    break;
                                    case 3:
                                    ComplexClass number5 = ComplexClass.Multiplication (number1, number2);
                                    Console.WriteLine($"Результат действия: {number5}");
                                    break;
                                //case 4:
                                //    ComplexClass number6 = ComplexClass.Division (number1, number2);
                                //    Console.WriteLine($"Результат действия: {number6}");
                                //    break;
                                case 0:
                                    m = false;
                                    Console.WriteLine("Завершение вычисления");
                                    break;
                                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;

                            }
                        }                       

                        Console.WriteLine();
                        break;
                    #endregion
                    
                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }
        }
    }
}
