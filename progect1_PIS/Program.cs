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
            
            StringManipulation stringManipulation = new StringManipulation();

            string themes1 = "\"Статус работы\" \"Казарез Полина Андреевна\" \"Практическая работа\" 2023.10.02 \"В процессе\"";
            string themes2 = "\"Тема работы\" \"Спепанова Лидия Ивановна\" \"Практическая работа\" 2024.09.09";
            string themes3 = "\"Работа с наставником\" \"Казарез Полина Андреевна\" \"Курсовая работа\" 2024.10.02 \"Иванов Михаил Ильич\"";
            string[] provera = new string[] { themes1, themes2, themes3 };

            
            Console.WriteLine("---------------------------------------------Вывод из строк------------------------------------");
            foreach (string linestr in provera)
            {
                Console.WriteLine(stringManipulation.ObjectOutput(linestr));
            }
            
            Console.WriteLine("---------------------------------------------Вывод из файла------------------------------------");
            foreach (string linefile in stringManipulation.StrFromFiles("2.txt"))
            {
                Console.WriteLine(stringManipulation.ObjectOutput(linefile));
            }
            Console.ReadKey();
        }
    }
}


