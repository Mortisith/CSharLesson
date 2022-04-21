using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Goncharenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Задание 1. Анкета
            Console.Write("Здравствуйте, для начала работы нам потребуются некоторые данные. Пожалуйста, укажите Вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Clear();
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Clear();
            Console.Write("Рост: ");
            string height = Console.ReadLine();
            Console.Clear();
            Console.Write("И последнее, Ваш вес: ");
            string  weight = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Отлично, давайте проверим данные: Фамилия и имя - " + surname +" "+ name + "." + "Возраст - " + age + "." + "Рост - " + height + "." + "Вес - " + weight + ".");
            Console.WriteLine("Отлично, давайте проверим данные: Фамилия и имя - {0} {1}. Возраст - {2}. Рост - {3}. Вес - {4}.", surname, name, age, height, weight);
            Console.WriteLine($"Отлично, давайте проверим данные: Фамилия и имя - {surname} {name}. Возраст - {age}. Рост - {height}. Вес - {weight}.");
            Console.ReadLine();
            #endregion
            

            
            #region Задача 2. Рассчитать ИМТ
            Console.WriteLine("Добрый день. Здесь вы сможете вычеслить индекс массы тела. Пожалуйста, введите данные:");
            Console.Write("Вес, в киллограмах: ");
            double mass = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Рост, в метрах: ");
            double growing = double.Parse(Console.ReadLine());
            Console.Clear();

            double index = mass / Math.Pow(growing, 2);
            Console.WriteLine("Ваш ИМТ: " + index);
            Console.ReadLine();
            #endregion
            

            
            #region Задание 3. Рассчитать расстояние между точками
             int x1 = 10;
             int y1 = 5;
             int x2 = 25;
             int y2 = 40;

            // без метода:
            // double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
              
             double r = distance(10,5,25,40);
             Console.WriteLine("Расстояние между точками: " + "{0:F2}",r);
             Console.ReadLine();
             #endregion
            
            #region Задание 4. Обмен данными
            /* с двумя переменными
            int a = 7;
            int b = 8;
            int e = a;
            a = b;
            b = e;
            Console.WriteLine($"{a}, {b}");
            Console.ReadLine();*/

            
            // с тремя переменными
            int a = 67;
            int b = 9;
            int c = 43;
            int e = a;
            int y = b;
            a = c;
            b = e;
            c = y;
            Console.WriteLine($"{a}, {b}, {c}");
            Console.ReadLine();
            #endregion
            

            #region Задание 5. Вывести надпись на консоле по координатам
            string fio = "Гончареко Людмила Андреевна, проживаю в городе Ковров. Россия";
            Console.SetCursorPosition(30,15);
            Console.WriteLine($"{fio}");
            Console.ReadLine();
            /* через метод: 
            Print(fio, 30,15);
            Console.ReadLine();*/
            #endregion
        }

        #region Задание 6. Методы для работы
        /// <summary>
        /// Рассчитать расстояние между точками
        /// </summary>
        /// <param name="x1"> значение х1</param>
        /// <param name="y1"> значение у1</param>
        /// <param name="x2"> значение х2</param>
        /// <param name="y2"> значение у2</param>
        /// <returns> Расстояние между двумя точками</returns>
        static double distance(int x1, int y1, int x2, int y2)
        {
            
            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return res;
        }
        /// <summary>
        /// Вывести надпись по определенным координатам
        /// </summary>
        /// <param name="fio"> Надпись для вывода на консоли</param>
        /// <param name="x"> координата х</param>
        /// <param name="y"> координата у</param>
        static void Print(string fio, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(fio);
        }

        /// <summary>
        /// Метод паузы, для приостановления работы консоли (чтобы не прописывать каждый раз Console.ReadLine
        /// </summary>
        static void Pause()
        {
            Console.ReadLine();
        }
        #endregion
    }


}
