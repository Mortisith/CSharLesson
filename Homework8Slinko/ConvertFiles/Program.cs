using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConvertFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "students.csv");

            var xml = new XElement("TopElement",
               lines.Select(line => new XElement("Item",line.Split(';')
               .Select((column, index) => new XElement("Column" + index, column)))));

            xml.Save(AppDomain.CurrentDomain.BaseDirectory + "xmlout.xml");
        }
    }
}
