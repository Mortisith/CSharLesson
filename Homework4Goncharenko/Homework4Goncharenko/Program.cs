using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.IO;


namespace Homework4Goncharenko
{
    class Account
    {
        public string Login { get; set; }
        public string Password { get; set; }

        private readonly string[] arrStr;
        public Account(string[] arr)
        {
            this.arrStr = new string [arr.Length];
            Array.Copy(arr, this.arrStr, arr.Length);

        }
        public Account(string fileName)
        {
            this.arrStr = LoadInfoFromFile(fileName);

        }

        private string[] LoadInfoFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

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
            return arr;
        }
        public string this[int index]
        {
            get
            {
                return arrStr[index];
            }

            set
            {
                arrStr[index] = value;
            }
        }

    }


    class TestArray
    {

        #region Fields

        private readonly int[] arr;
        private readonly string[] arrStr;

        public int Length { get; private set; }

        #endregion

        #region Properties

       

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }
      
        #endregion

        #region Constructors


        public TestArray(int count)
        {
            Random rnd = new Random();
            this.arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                this.arr[i] = rnd.Next(-10000, 10001);
            }

        }

        public TestArray(int[] arr)
        {
            this.arr = new int[arr.Length];
            Array.Copy(arr, this.arr, arr.Length);

        }
        public TestArray(string[] arr)
        {
            this.arrStr = arr;
            Array.Copy(arr, this.arrStr, arr.Length);

        }


        public TestArray(string fileName)
        {
            this.arr = LoadArrayFromFile(fileName);
        }
        //public TestArray(string fileName)
        //{
        //   this.arrStr = LoadInfoFromFile(fileName);
            
        //}

        #endregion

        #region Methods

        public static string [] ConvertToString (TestArray e)
        {
            string [] arr = new string[e.Length];
            return arr;
        }

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[] bonus = new int[1000];
            int counter = 0;


            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                bonus[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }

            streamReader.Close();

            int[] arr = new int[counter];
            Array.Copy(bonus, arr, counter);
            return arr;
        }
        public string[] LoadInfoFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

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
            return arr;
        }


        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\n");
            }
            Console.WriteLine();
        }

        #endregion

        public static void StepNumber(int z)
        {
            int c = z;
            int [] arr2 = new int [7];
            TestArray arr01 = new TestArray(arr2);

            Console.Write($"Новый массив с шагом: {c}\n");

            for (int i = 1; i < arr01.Length; i++)
            {
                arr01[i] = arr01[i-1] + c;                
                
                Console.Write($"{arr01[i]}\t");   
                
            }
            

        }

        public static void Inverse(TestArray e)
        {           
            
            TestArray arr01 = e;
            for (int i = 0; i < arr01.Length; i++)
            {
                arr01[i] = arr01[i]* -1;
                Console.Write($"Инверсированный массив: \n {arr01[i]}\t");
            }
            
        }
         public static int Sum(TestArray e)
        {
            int sum = 0;
            for (int i = 0; i < e.Length; i++)
            {
                sum = sum + e[i];
            }
            return sum;
        }
        public static void Multi(TestArray e, int z)
        {
            int c = z;
            TestArray arr01 = e;
            for (int i = 0; i < arr01.Length; i++)
            {
                arr01[i] = arr01[i] * c;
                Console.Write($"Новый массив: \n {arr01[i]}\t");
            }
        }
        public static int MaxCount(TestArray e)
        {
            int max = e[0];
            int counter = 1;
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i] > max)
                {
                    max = e[i];
                } if (e[i] == max)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Максимальных чисел в массиве: {counter}");
            return max; 
        }


         public static void  Calcul( TestArray e)
        {
            TestArray arr = e;
           
            int counter = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i - 1] % 3 != 0 || arr[i] % 3 != 0 && arr[i - 1] % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно: {counter}");
            
            
            
        }
        

    }
    internal class Program
    {


        static void Main(string[] args)
        {

            StudentHelper.PrintFIO(4, "Гончаренко Людмила");

            bool f = true;

            while (f)
            {
                #region меню
                Console.Clear();
                Console.WriteLine("Домашняя работа по теме: Массивы. Текстовые файлы.");
                Console.WriteLine("**************************************************");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("5 -> Задача 5");
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

                    #region второе задание
                    case 2:
                        Console.Clear();
                        TestArray array01 = new TestArray(17);
                        array01.PrintArray();
                        TestArray.Calcul(array01);
                        Console.ReadLine();

                        Console.Clear();
                        TestArray nextArr = new TestArray(AppDomain.CurrentDomain.BaseDirectory + "TestArrayList.txt");
                        nextArr.PrintArray();
                        TestArray.Calcul(nextArr);
                        Console.ReadLine();

                        break;
                    #endregion

                    #region третье задание
                    case 3:
                        Console.Clear();
                        TestArray arrNumber = new TestArray(7);
                        arrNumber.PrintArray();
                        TestArray.StepNumber(5);
                        TestArray.Inverse(arrNumber);
                        int sum;
                        sum = TestArray.Sum(arrNumber);
                        Console.WriteLine($"Сумма чисел массива: {sum}");
                        TestArray.Multi(arrNumber, 3);
                        int max;
                        max = TestArray.MaxCount(arrNumber);
                        Console.WriteLine($"Максимальное число массива: {max}");
                        Console.ReadLine();

                        break;
                    #endregion

                    #region четвертое задание
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Mетод проверки логина и пароля.");
                        Console.WriteLine("*******************************");

                        //Account accountChek;
                        //accountChek.Login = "root";
                        //accountChek.Password = "GeekBrains";

                        Account LoginAccount = new Account(AppDomain.CurrentDomain.BaseDirectory + "TryLogin.txt");
                        

                        if (LoginAccount[0]=="root" && LoginAccount[1] == "GeekBrains")
                        {
                            Console.WriteLine("Авторизация прошла успешно");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Данные не совпадают");
                        }
                        Console.ReadLine();
                        break;
                    #endregion

                    #region пятое задание
                    case 5:
                        bool m = true;
                        while (m)
                        {
                            Console.Clear();
                            Console.WriteLine("Работа с двумерными массивами.");
                            Console.WriteLine("**************************************************");
                            Console.WriteLine("1 -> Сгенерировать случайный массив");
                            Console.WriteLine("2 -> Запись массива на файл");
                            Console.WriteLine("3 -> Вычислить сумму элементов массива");
                            Console.WriteLine("4 -> Вычислить максимальный элемент массива");
                            Console.WriteLine("5 -> Вычислить минимальный элемент массива");
                            Console.WriteLine("0 -> Завершение работы приложения");
                            Console.WriteLine("*********************************\n");

                            Console.Write("Пожалуйста,введите номер: ");
                            int number1 = int.Parse(Console.ReadLine());

                            switch (number1)
                            {
                                case 1:
                                    Console.Clear();
                                    MatrixArray arr04 = new MatrixArray(3,3);
                                    arr04.PrintArray();
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Clear();
                                    MatrixArray.WriteArrayToFile(AppDomain.CurrentDomain.BaseDirectory + "ToList.txt");
                                    Console.WriteLine("Текстовый файл находится в папке: D/C#");
                                    break;
                                case 3:
                                    int summN;
                                    MatrixArray arr05 = new MatrixArray(3,3);
                                    summN = MatrixArray.SumNumber(arr05);
                                    Console.WriteLine(summN);
                                    break;
                                case 4:
                                    MatrixArray arr06 = new MatrixArray(3,3);
                                    MatrixArray.MaxNumber(arr06);
                                    break;
                                case 5:
                                    MatrixArray arr07 = new MatrixArray(3,3);
                                    MatrixArray.MinNumber(arr07);
                                    break;
                                case 0:
                                    Console.Clear();
                                    Console.SetCursorPosition(45, 5);
                                    Console.WriteLine("Спасибо за уделенное время");
                                    Console.ReadKey();
                                    f = false;
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                                    break;

                            }
                        }

                        break;
                    #endregion

                    #region первое задание
                    case 1:
                        TestArray arr1 = new TestArray(20);
                        arr1.PrintArray();


                        int counter = 0;

                        for (int i = 1; i < 20; i++)
                        {
                            if (arr1[i] % 3 == 0 && arr1[i - 1] % 3 != 0 || arr1[i] % 3 != 0 && arr1[i - 1] % 3 == 0)
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно: {counter}");
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;
                }

                  

                Console.ReadLine();



            }
        }
    }
}
