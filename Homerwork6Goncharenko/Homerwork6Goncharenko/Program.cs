using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Homerwork6Goncharenko
{
   
    internal class Program
    {
        public delegate double Fun(double x, double y);

        public static void Table(Fun F, double x, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
       
        public static double MyFunc(double x, double y)
        {
            return (x * x) * y;
        }

        public delegate double FunDelegate(double x);


        public static string [] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            
            double  d;


            string[] bonus = new string[5];
            int counter = 0;


            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                bonus[counter] = streamReader.ReadLine();
                counter++;                

            }

            streamReader.Close();

            string[] arr = new string[counter];
            Array.Copy(bonus, arr, counter);
            Console.WriteLine(arr);
            return arr;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            
        }
        public static double F( double x)
        {
           
            return x * x - 50 * x + 10;
        }
        public static double Fn2(double x)
        {

            return x  - 4 * x / 3;
        }
        public static double Fn3(double x)
        {

            return x * x * 7 * x - 12;
        }
        public static double Fn4(double x)
        {

            return x * x +3 * x;
        }
        public static double Fn5(double x)
        {

            return x * x / 50 * x * 2;
        }
        public static double Fn6(double x)
        {

            return x * x + 50 * x - 10;
        }


        public static void SaveFunc(string fileName, FunDelegate Fun, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }


        static void Main(string[] args)
        {
            StudentHelper.PrintFIO(6, "Гончаренко Людмила");

            bool f = true;

            while (f)
            {
                #region меню
                Console.Clear();
                Console.WriteLine("Домашняя работа по теме: Делегаты, файлы, коллекции.");
                Console.WriteLine("****************************************************");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");                
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("*********************************\n");

                Console.Write("Пожалуйста,введите номер задачи для проверки: ");
                int number = int.Parse(Console.ReadLine());
                #endregion

                switch (number)
                {
                    #region завершение
                    case 0:
                        Console.Clear();
                        Console.SetCursorPosition(45, 5);
                        Console.WriteLine("Спасибо за уделенное время");
                        Console.ReadKey();
                        f = false;
                        break;
                    #endregion

                    #region первое задание
                    case 1:

                        Console.WriteLine("Таблица функции a*x^2:");
                        
                        Table(MyFunc, 3, 5);

                        Console.WriteLine("Таблица функции a*sin(x):");

                        Table(delegate (double x, double y)
                        {
                            return Math.Sin(x) * y;
                        },-4,2);
                        
                        Console.ReadLine();
                        break;
                    #endregion

                    #region второе задание
                    case 2:
                        Console.Clear();
                        Dictionary<FunDelegate, string> funcDict = new Dictionary<FunDelegate, string>();
                        funcDict.Add(Fn6, "x * x + 50 * x - 10");
                        funcDict.Add(Fn2, "x  - 4 * x / 3");
                        funcDict.Add(Fn3, "x * x * 7 * x - 12");
                        funcDict.Add(Fn4, "x * x +3 * x");
                        funcDict.Add(Fn5, "x * x / 50 * x * 2");
                        int numberFun;
                        double min;

                        

                        Console.Write("\nВыберите функцию для работы, 0 - выход: ");
                        if (int.TryParse(Console.ReadLine(), out numberFun) && numberFun >= 0 && numberFun <= funcDict.Count)
                        {
                            if (numberFun == 0)
                                break;
                            Console.WriteLine($"Функция: {numberFun}: {funcDict.ElementAt(numberFun - 1).Value}\n");
                            SaveFunc("data.bin", funcDict.ElementAt(number - 1).Key, -100, 100, 0.5);
                            Console.WriteLine(string.Join(" ", Load("data.bin", out min)));
                            Console.WriteLine($"Минимальное значение: {min}");
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Номер введен некорректно.");


                   
                    Console.ReadKey();
                        

                        break;
                    #endregion

                    case 3:

                        int bakalavr = 0;
                        int magistr = 0;
                        int countBakalavr = 0;
                        int countMagistr = 0;
                        ArrayList list = new ArrayList();
                        int Level1 = 0;
                        int Level2 = 0;
                        int Level3 = 0;
                        int Level4 = 0;
                        int Level5 = 0;
                        int Level6 = 0;

                        DateTime dt = DateTime.Now;
                        StreamReader sr = new StreamReader(@"D:\C#\Homerwork6Goncharenko\\students.csv");
                        while (!sr.EndOfStream)
                        {
                            try
                            {
                                
                                string[] s = sr.ReadLine().Split(';');
                                                             
                                list.Add(s[1] + " " + s[0]);
                                if (int.Parse(s[6]) < 5)
                                {
                                    bakalavr++;
                                    countBakalavr++;

                                }
                                else 
                                {
                                    magistr++;
                                    countMagistr++;
                                }
                                for (int i = 1; i <= s.Length; i++)
                                {
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 1)
                                    {
                                        Level1++;
                                    }
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 2)
                                    {
                                        Level2++;
                                    }
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 3)
                                    {
                                        Level3++;
                                    }
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 4)
                                    {
                                        Level4++;
                                    }
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 5)
                                    {
                                        Level5++;
                                    }
                                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20 && int.Parse(s[6]) == 6)
                                    {
                                        Level6++;
                                    }
                                }

                            } catch { }
                            
                            
                        }
                        sr.Close();
                        list.Sort();
                        Console.WriteLine("Всего студентов:{0}", list.Count);
                        Console.WriteLine("Магистров:{0}", magistr);
                        Console.WriteLine("Бакалавров:{0}", bakalavr);
                        Console.WriteLine($"На пятом курсе обучается {countBakalavr} человека");
                        Console.WriteLine($"На шестом курсе обучается {countMagistr} человека");
                        foreach (var v in list) Console.WriteLine(v);
                        
                        Console.WriteLine($"Колличество студентов в возрасте от 18 до 20 лет на курсах: \n на первом: {Level1}\n на втором: {Level2}\n на третьем: {Level3}\n на четвертом: {Level4}\n на пятом: {Level5}\n на шестом: {Level6}");
                       

                        // Вычислим время обработки данных
                        //Console.WriteLine(DateTime.Now - dt);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;
                }


               

                    
                
            }
        }
    }
}


