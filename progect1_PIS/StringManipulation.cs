using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace progect1_PIS
{
    internal class StringManipulation
    {
        public static List<string> ParseString(string input)
        {
            return Regex.Matches(input, @"[\""].+?[\""]|[^ ]+")
                         .Cast<Match>()
                         .Select(m => m.Value)
                         .ToList();
        }


        public ThemesOfTheWorks ObjectOutput(string stroka)
        {
            var parts = ParseString(stroka);

            if (parts[0].Trim('"') == "Тема работы")
            {
                return new ThemesOfTheWorks(parts[0].Trim('"'), parts[1].Trim('"'), parts[2].Trim('"'), DateTime.ParseExact(parts[3], "yyyy.MM.dd", null));
            }
            else if (parts[0].Trim('"') == "Работа с наставником")
            {
                return new WorksWithAMentor(parts[0].Trim('"'), parts[1].Trim('"'), parts[2].Trim('"'), (DateTime.ParseExact(parts[3], "yyyy.MM.dd", null)), parts[4].Trim('"'));
            }
            else
            {
                return new StatusOfWorks(parts[0].Trim('"'), parts[1].Trim('"'), parts[2].Trim('"'), (DateTime.ParseExact(parts[3], "yyyy.MM.dd", null)), parts[4].Trim('"'));
            }
        }

        public string[] StrFromFiles(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return fileContent.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
