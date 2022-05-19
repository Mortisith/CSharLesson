using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework5Goncharenko
{
    

    public static class Message
    {
        //public override string ToString(string [] words)
        //{
        //    //return base.ToString();
        //    return $"{words.Length}";
        //}
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static void AsAnagram( string m, string e)
        {
            string[] words2 = e.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            char[] word1 = m.ToLower().ToCharArray();
            char[] word2 = e.ToLower().ToCharArray();
            Array.Sort(word1);
            Array.Sort(word2);

            string CheckWord1 = new string(word1);
            string CheckWord2 = new string(word2);
            if (CheckWord1 == CheckWord2)
            {
                Console.WriteLine("Строка 2 является аннаграмой строки 1");
            }
            else
            {
                Console.WriteLine("Cтроки не являются аннаграмой");
            }

            
        }

        public static void PrintWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                
                if (words[i].Length >= 3 && words[i][0].Equals(words[i][words[i].Length - 1]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
        public static void PrintAsSize(string message, int x)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= x )
                {
                    Console.Write($"Подходящиее слова: {words[i]}");
                }
            }
        }
        public static void DeleteWords(string message, char z)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string newmess;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1].Equals(z))
                {
                   newmess = words[i].Remove(words[i].Length - 1);
                    Console.Write($"Оставшиеся слова: {newmess}");
                }                
                
            }          
                       
        }

        public static void MaxWord(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string maxmess = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > maxmess.Length)
                {
                    maxmess = words[i];
                } 
               
            }
            Console.Write($"Самое длинное слово:  { maxmess}");
        }
        public static void MaxWordForStrBild(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string maxmess = words[0];
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= maxmess.Length)
                {
                    maxmess = words[i];
                    stringBuilder.Append($"{words[i]}\t" );
                }

            }
            Console.WriteLine(stringBuilder.ToString());
        }


    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            StudentHelper.PrintFIO(5, "Гончаренко Людмила");

            bool f = true;

            while (f)
            {
                #region меню
                Console.Clear();
                Console.WriteLine("Домашняя работа по теме: Символы, строки, регулярные выражения.");
                Console.WriteLine("***************************************************************");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");                
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
                        Console.Clear();
                        Console.Write("Пожалуйста, придумайте логин.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой: ");
                        string login = Console.ReadLine();
                        char[] arr = login.ToCharArray();
                        int counter = 0;
                        if (arr.Length != 1 && arr.Length <= 10)
                        {
                            for (int i = 0; i < arr.Length; i++)
                            {
                                UnicodeCategory unicideCategory = char.GetUnicodeCategory(arr[i]);
                                if (Char.IsDigit(arr[0]))
                                {
                                    Console.WriteLine("Условия не выполнены");
                                    break;
                                }
                                if ((int)unicideCategory >= 1040 && (int)unicideCategory <= 1103)
                                {
                                    Console.WriteLine("Условия не выполнены");
                                    break;
                                }
                                switch (unicideCategory)
                                {

                                    case UnicodeCategory.UppercaseLetter:
                                        counter++;
                                        break;
                                    case UnicodeCategory.LowercaseLetter:
                                        counter++;
                                        break;
                                    case UnicodeCategory.DecimalDigitNumber:
                                        counter++;
                                        break;

                                    default:
                                        Console.WriteLine("Условия не выполнены");
                                        break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Условия не выполнены");

                        }
                        if (counter >= 2)
                        {
                            Console.WriteLine("Корректный ввод");
                        }

                        Console.ReadKey();

                        Console.Write("Пожалуйста, придумайте логин.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой: ");
                        string login2 = Console.ReadLine();
                        
                        Regex regex = new Regex("(^[A-Za-z])([A-Za-z0-9]{2,10})");
                        bool x = regex.IsMatch(login2);
                        if (x) 
                        { 
                            Console.WriteLine("Корректный ввод"); 
                            
                        } else 
                        { 
                            Console.WriteLine("Некорректный ввод");                            
                        }
                        Console.ReadKey();
                        break;
                    #endregion

                    #region второе задание
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Пожалуйста, введите предложение: ");
                        string mess = Console.ReadLine();
                        Console.WriteLine("Укажите размер слова: ");
                        int a = int.Parse(Console.ReadLine());
                        Message.PrintAsSize(mess, a);
                        Message.DeleteWords(mess, 'и');
                        Message.MaxWord(mess);
                        Message.MaxWordForStrBild(mess);



                        Console.ReadKey();

                        break;
                    #endregion

                    #region третье задание
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Пожалуйста, введите первое слово: ");
                        string messOrig = Console.ReadLine();
                        Console.WriteLine("Пожалуйста, введите второе слово: ");
                        string messСheck = Console.ReadLine();
                        Message.AsAnagram(messOrig, messСheck);

                        Console.ReadKey();

                        break;
                    #endregion

                    #region четвертое задание
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Результаты экзаменов за 9й класс школы №N: ");


                        if (!File.Exists("TextFile1.txt"))
                            throw new FileNotFoundException();

                        StringBuilder stringBuilder = new StringBuilder(); 
                        


                        StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");

                        while (!streamReader.EndOfStream)
                        {
                            stringBuilder.AppendLine(streamReader.ReadLine());
                            
                        }

                        streamReader.Close();



                        Console.WriteLine(stringBuilder.ToString());

                        int minRat = 3;
                        stringBuilder.ToString().Split(' ');
                        for (int i = 0; i < stringBuilder.Length; i++)
                            if (((int)stringBuilder[i][2] + (int)stringBuilder[i][3] + (int)stringBuilder[i][4]) / 3 <= minRat)
                                Console.WriteLine(stringBuilder[i]);

                        Console.ReadKey();

                        break;
                    #endregion

                    default:
                        Console.WriteLine("Вы ввели некорректный номер задачи.\nПовторите ввод.");
                        break;
                        Console.ReadKey();

                }

            }

        }

    }
}
