using System;

namespace Assignment2
{
    enum Status{
        New, Active, Dropout, Graduated
    }
    class Student
    {
        int id;
        string GivenName, Surname;
        Status Status;
        DateTime StartDate, EndDate, GraduationDate;
        
        

        static void Main(string[] args)
        {
            var e = new DateTime(2001, 1, 5);
            Console.WriteLine(e.ToString("yyyy/mm/dd"));
        }
    }
}
