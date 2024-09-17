using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace progect1_PIS
{
    class ThemesOfTheWorks
    {
        public string StudentName { get; }
        public string Theme { get; }
        public DateTime DateOfIssue { get; }

        public ThemesOfTheWorks(string input)
        {
            var parts = Regex.Matches(input, @"[\""].+?[\""]|[^ ]+").Cast<Match>().Select(m => m.Value).ToList();
            StudentName = parts[0].Trim('/', '"');
            Theme = parts[1].Trim('/', '"');
            DateOfIssue = DateTime.ParseExact(parts[2], "yyyy.MM.dd", CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return $"Имя студента: {StudentName}; \fТема работы: {Theme}; \fДата выдачи: {DateOfIssue}";
            
        }

    }
}
