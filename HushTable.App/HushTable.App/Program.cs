using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HushTable.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hushtable aHashtable = new Hushtable();
            aHashtable.Add("111", "Asp.Net");
            aHashtable.Add("222", "Java Basics");
            aHashtable.Add("101", "Laravel");
            aHashtable.Add("102", "Zend");
            aHashtable.Add("987", "SEO");
            string courseName = (string)aHashtable["101"];
            Console.WriteLine(courseName);
            Console.Read();
        }
    }
}
