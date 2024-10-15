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
        

        public ThemesOfTheWorks(string type, string studentsName, string topicName, DateTime dateOfIssue)
        {
            Type = type;
            StudentsName = studentsName;
            TopicName = topicName;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"--{Type}-- \nИмя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")}\n";
        }
    }





    class WorksWithAMentor : ThemesOfTheWorks
    {

        public string MentorsName { get; set; }

        
        public WorksWithAMentor(string type, string studentsName, string topicName, DateTime dateOfIssue, string mentorsName) : base(type, studentsName, topicName, dateOfIssue) 
        {
            MentorsName = mentorsName;
        }

        public override string ToString()
        {
            return $"--{Type}-- \nИмя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")}, Имя наставника: {MentorsName}\n";
        }
    }






    class StatusOfWorks : ThemesOfTheWorks
    {
        public string Status { get; set; }

        public StatusOfWorks(string type, string studentsName, string topicName, DateTime dateOfIssue, string status) : base(type, studentsName, topicName, dateOfIssue)
        {
            Status = status;
        }
        public override string ToString()
        {
            return $"--{Type}-- \nИмя студента: {StudentsName}, Название темы: {TopicName}, Дата выдачи: {DateOfIssue.ToString("yyyy.MM.dd")}, Статус работы: {Status}\n";
        }
    }

   
}
