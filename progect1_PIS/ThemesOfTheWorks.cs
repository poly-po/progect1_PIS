using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace progect1_PIS
{
    class ThemesOfTheWorks
    {
        public string Type { get; set; }
        public string StudentsName { get; set; }
        public string TopicName { get; set; }
        public DateTime DateOfIssue { get; set; }
        


        public ThemesOfTheWorks(string input)
        {
            var parts = MainString.ParseString(input);
            Type = parts[0].Trim('"');
            StudentsName = parts[1].Trim('"');
            TopicName = parts[2].Trim('"');
            DateOfIssue = DateTime.ParseExact(parts[3], "yyyy.MM.dd", null);
        }

        public virtual string LineOutput()
        {
            return $"{Type}: Имя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")} ";
        }
    }
    class WorksWithAMentor : ThemesOfTheWorks
    {
        public string MentorsName { get; set; }

        public WorksWithAMentor(string input) : base(input)
        {
            var parts = MainString.ParseString(input);
            MentorsName = parts[4].Trim('"');
        }

        public override string LineOutput()
        {
            return $"{Type}: Имя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")}, Имя наставника: {MentorsName} ";
        }
    }
    class StatusOfWorks : ThemesOfTheWorks
    {
        public string Status { get; set; }

        public StatusOfWorks(string input) : base(input)
        {
            var parts = MainString.ParseString(input);
            Status = parts[4].Trim('"');
        }
        public override string LineOutput()
        {
            return $"{Type}: Имя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")}, Статус работы: {Status}";
        }
    }

    class MainString
    {
        public string[] StrFromFiles(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);
            return fileContent.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static List<string> ParseString(string input)
        {
            return Regex.Matches(input, @"[\""].+?[\""]|[^ ]+")
                         .Cast<Match>()
                         .Select(m => m.Value)
                         .ToList();
        }

        public string ObjectOutput(string stroka)
        {
            var parts = ParseString(stroka);

            if (parts[0].Trim('"') == "Тема работы")
            {
                ThemesOfTheWorks type1 = new ThemesOfTheWorks(stroka);
                return type1.LineOutput();
            }
            else if (parts[0].Trim('"') == "Работа с наставником")
            {
                WorksWithAMentor type2 = new WorksWithAMentor(stroka);
                return type2.LineOutput();
            }
            else if (parts[0].Trim('"') == "Статус работы")
            {
               StatusOfWorks type3 = new StatusOfWorks(stroka);
                return type3.LineOutput();
            }
            else
                return "Возникла ошибка";
        }
    }
}
