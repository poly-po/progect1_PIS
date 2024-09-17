using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progect1_PIS
{
    class Program
    {
        static void Main()
        
        {
            ThemesOfTheWorks themesOfTheWorks =
            new ThemesOfTheWorks("\"Казарез Полина Андреевна\" \"Курсовая работа\" 2024.10.20");

            Console.WriteLine(themesOfTheWorks.ToString());
            Console.ReadKey();
        }
    }
}


