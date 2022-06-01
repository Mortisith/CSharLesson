using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework8Slinko
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Type type1 = typeof(DateTime);

            PropertyInfo [] propertyInfo = type1.GetProperties();
            foreach (PropertyInfo property in propertyInfo)
            {
                                   
                    Console.WriteLine(property);
               

            }
             Console.ReadLine();
        }
    }
}
