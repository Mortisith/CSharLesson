using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.IO;

namespace Helper
{
    public class MatrixArray
    {
        private int[,] matrixArr;

        public int this[int index1, int index2]
        {
            get
            {
                return matrixArr[index1, index2];
            }

            set
            {
                matrixArr[index1, index2] = value;
            }
        }
        public int Length
        {
            get { return matrixArr.GetLength(0); }
            set { matrixArr[0, 0] = value; }
        }

        public MatrixArray(int[,] arr)
        {
            this.matrixArr = new int[arr.Length, arr.Length];
            Array.Copy(arr, this.matrixArr, arr.Length);

        }
        public MatrixArray(int e, int z)
        {
            int[,] arr01 = new int[e, z];
            Random random = new Random();

            for (int i = 0; i < arr01.GetLength(0); i++)
            {
                for (int j = 0; j < arr01.GetLength(1); j++)
                {
                    arr01[i, j] = random.Next(-99, 100);
                    Console.Write($"{arr01[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
        public MatrixArray(string fileName)
        {
            this.matrixArr = LoadArrayFromFile(fileName);
        }
        

        public void PrintArray()
        {
            for (int i = 0; i < matrixArr.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArr.GetLength(1); j++)
                {
                    Console.Write($"{matrixArr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        private int[,] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[,] buf = new int[1000, 1000];
            int b = 0;
            int a = 0;
            int counter = 0;


            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                buf[a, b] = int.Parse(streamReader.ReadLine());
                a++; b++;
                counter++;
            }

            streamReader.Close();

            int[,] arr = new int[a, b];
            Array.Copy(buf, arr, counter);
            return arr;
        }
        
        public static void WriteArrayToFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            MatrixArray buf = new MatrixArray(5,3);
            
            

            StreamWriter streamWriter = new StreamWriter(fileName);


            for (int i = 0; i < buf.Length; i++)
            {
                for (int j = 0; j < buf.Length; j++)
                {
                    streamWriter.WriteLine(buf[i, j]);
                }
            }

           
            streamWriter.Close();

            
        }

        public static void MaxNumber(MatrixArray e)
        {
            int x = 0;
            int y = 0;
            int max = e[x, y];

            for (int i = 0; i < e.Length; i++)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    if (e[i, j] > max)
                    {
                        max = e[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            Console.WriteLine($"Максимальное значение элемента двумерного массива: {max}");
            Console.WriteLine($"расположено по индексу [{x},{y}]");
        }

        public static int SumNumber(MatrixArray e)
        {
            int sum = 0;
            for (int i = 0; i < e.Length; i++)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    sum = sum + e[i, j];
                }
            }
            return sum;
        }

        public static void MaxNum(MatrixArray e)
        {
            int max = 0;

            for (int i = 0; i < e.Length; i++)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    if (e[i, j] > max)
                    {
                        max = e[i, j];

                    }
                }
            }

            Console.WriteLine($"Максимальное значение элемента двумерного массива: {max}");

        }
        public static void MinNumber (MatrixArray e)
        {
            int min = 0;
            for (int i = 0; i < e.Length; i++)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    if (e[i, j] < min)
                    {
                        min = e[i, j];

                    }
                }
            }

            Console.WriteLine($"Наименьшее значение элемента двумерного массива: {min}");
        }

    }


    class MyArray
    {

        #region Fields

        private int[] arr;

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


        public MyArray(int count)
        {
            Random rnd = new Random();
            this.arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                this.arr[i] = rnd.Next(-99, 100); // -99 - 99
            }

        }

        public MyArray(int[] arr)
        {
            this.arr = new int[arr.Length];
            Array.Copy(arr, this.arr, arr.Length);

        }

        public MyArray(string fileName)
        {
            this.arr = LoadArrayFromFile(fileName);
        }

        #endregion

        #region Methods

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            int[] buf = new int[1000];
            int counter = 0;

            // StreamWriter streamWriter = new StreamWriter(fileName);
            // streamWriter.WriteLine();

            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
                buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }

            streamReader.Close();

            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);
            return arr;
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        #endregion

    }
    public class StudentHelper
    {
        /// <summary>
        /// Вывод ФИО а экране
        /// </summary>
        /// <param name="homeworkNumber"> Номер ДЗ</param>
        /// <param name="fio"> ФИО учащегося </param>
        public static void PrintFIO(int homeworkNumber, string fio)
        {

            Console.WriteLine($"Домашная работа к уроку номер {homeworkNumber}");
            Console.WriteLine($"Студент: {fio}");
            Console.WriteLine("****************************************");
            Pause();
        }
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        static void Pause()
        {
            Console.ReadKey();
        }


        /// <summary>
        /// Проверка четности числа
        /// </summary>
        /// <param name="a"> число </param>
        /// <returns> Возврат четного</returns>
        /*public static int  CheckEven(int a)
        {
            if (a % 2 != 0)
            {
                return  a;
            }
                
        }*/
        

    }

}


