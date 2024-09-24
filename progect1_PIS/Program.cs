using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace progect1_PIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MainString mainstr = new MainString();

            string income1 = "\"Статус работы\" \"Казарез Полина Андреевна\" \"Курсовая работа\" 2023.10.02 \"В процессе\"";
            string income2 = "\"Тема работы\" \"Спепанова Лидия Ивановна\" \"Практическая работа\" 2024.09.09";
            string income3 = "\"Работа с наставником\" \"Казарез Полина Андреевна\" \"Курсовая работа\" 2023.10.02 \"Иванов Михаил Ильич\"";
           

            Console.WriteLine("Вывод из строк");
            string[] provera = new string[] { income1, income2, income3};
            foreach (string linestr in provera)
            {
                Console.WriteLine(mainstr.ObjectOutput(linestr));
            }

            Console.WriteLine("\nВывод из файла");
            foreach (string linefile in mainstr.StrFromFiles("2.txt"))
            {
                Console.WriteLine(mainstr.ObjectOutput(linefile));
            }
            Console.ReadKey();
        }
    }
}


