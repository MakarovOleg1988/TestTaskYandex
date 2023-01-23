using System;

namespace Example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();


            if (char.IsDigit(s[s.Length - 1]) || s.Contains(" "))
            {
                Console.WriteLine("Строка s содержит пробелы или цифры");
            }
            else Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}