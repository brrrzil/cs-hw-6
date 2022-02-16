using System;
using System.IO;

namespace HW6
{
    class Program
    {
        public static void ReadCatalog()
        {
            if (File.Exists(@"D:\Unity\SkillBox\HomeWork\C#\HW6\catalog.txt"))
            {
                string text = File.ReadAllText(@"D:\Unity\SkillBox\HomeWork\C#\HW6\catalog.txt");
                Console.Write(text);
            }
            else 
            {
                string firstLine = ("Дата добавления\t ID \t ФИО сотрудника\t Дата рождения\t Рост\t Место рождения\t Возраст\n");
                File.AppendAllText(@"D:\Unity\SkillBox\HomeWork\C#\HW6\catalog.txt", firstLine);
            }
        }

        public static void AddLine(string newLine)
        {
                File.AppendAllText(@"D:\Unity\SkillBox\HomeWork\C#\HW6\catalog.txt", newLine);
        }

        public static string NewLine()
        {
            ReadCatalog();
            Console.WriteLine();
            Console.Write("Добавить нового сотрудника? y/n: ");
            string answer = Console.ReadLine().ToString();
            Console.WriteLine(answer);
            if (answer == "y")
            {
                string newLine;
                string lineID;
                string lineDate;
                string lineFIO;
                string lineHeight;
                string lineBirthDateString;
                string lineBirthPlace;

                DateTime Date = new DateTime(2021, 12, 15, 12, 35, 00);
                DateTime LineBirthDateDate = new DateTime(1900, 12, 19);
                int LineAgeSpan;

                lineDate = DateTime.Now.ToString();

                Console.WriteLine("Введите ID сотрудника:");
                lineID = Console.ReadLine();

                Console.WriteLine("Введите ФИО сотрудника:");
                lineFIO = Console.ReadLine();

                Console.WriteLine("Введите дату рождения сотрудника в формате ДД, ММ, ГГГГ:");
                lineBirthDateString = Console.ReadLine();
                LineBirthDateDate = DateTime.Parse(lineBirthDateString);
                LineAgeSpan = DateTime.Now.Year - LineBirthDateDate.Year;

                Console.WriteLine("Введите рост сотрудника:");
                lineHeight = Console.ReadLine();

                Console.WriteLine("Введите место рождения сотрудника:");
                lineBirthPlace = Console.ReadLine();

                return newLine = 
                lineDate + "\t"
                + lineID + "\t"
                + lineFIO + "\t"
                + lineBirthDateString + "\t"
                + lineHeight + "\t"
                + lineBirthPlace + "\t"
                + LineAgeSpan + "\t"
                + "\n";
            }
            else return null;
        }

        static void Main(string[] args)
        {
            string newLine = NewLine();
            AddLine(newLine);
            ReadCatalog();
        }
    }
}