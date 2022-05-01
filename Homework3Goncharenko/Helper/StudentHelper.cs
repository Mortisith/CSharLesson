using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Helper
{
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

