using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace _01.Class_Student
{
    internal class Problems1to12
    {
        private static void Main()
        {

            //Problem 1.	Class Student
            var students = new List<Student>
            {
             new Student("Elena", "Bojilova",30,900020915,"+359 2 89430817","elena.bojilova@abv.bg",new List<int> {2, 4, 5, 6},1,"LONDON"),
            new Student("Katya", "Marincheva",30,901020915,"02 899430817","katya@abv.bg",new List<int> {5, 6, 5, 6},1, "LONDON"),
            new Student("Nikolay", "Ivanov",17,921020915,"+359 897430826","nikola@abv.bg",new List<int> {6, 2, 6, 2},2,"PARIS"),
            new Student("Viktor", "Kazakov",24,924020915,"+359297456826","viktor@gmail.com",new List<int> {2, 6, 6, 6},2, "PARIS"),
            new Student("Filip", "Kolev",21,924030914,"+359 897434561","filip.k@ght.gh",new List<int> {2, 6, 6, 6},1, "LONDON"),
            new Student("Nikolay", "Paunov",25,924050915,"+359 845634561","paunov@abv.bg",new List<int> {4, 2, 6, 6},2,"PARIS"),
            new Student("Asen", "Tahchiski",22,024056914,"+359 845632345","asen@hotmail.com",new List<int> {6, 6, 6, 6},3,"NEW YORK"),
            };


            //Problem 2. StudentsByGroup

            Console.WriteLine("Problem 2. Students By Group");

            var studentsByGroup = from stud in students
                                    where stud.GroupNumber == 2
                                    orderby stud.FirstName
                                    select stud;
            var studentsByGroupSecTry = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);//vtori nachin Linq-Extension Methods
            PrintCollection(studentsByGroup);
            Console.WriteLine();

           
            //Prob 3
            Console.WriteLine("Problem 3. Students by First ans Last name");
            var studentsByName = from stud in students
                                where stud.FirstName.CompareTo(stud.LastName) < 0
                                select stud;
            var studsByNameSec = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            PrintCollection(studsByNameSec);


            //PRob 4
            Console.WriteLine("Problem 4. Students by age");
            var studentsByAge = from stud in students
                                where stud.Age >= 18 && stud.Age <= 24
                                select new {stud.FirstName, stud.LastName, stud.Age};
            var studentsbyAgeSec = students.Where(st => st.Age >= 18 && st.Age <= 24).Select(st => new {st.FirstName,st.LastName,st.Age});

            PrintCollection(studentsByAge);

            //Problem 5
            Console.WriteLine("Problem 5. Sort Students");

            var sortedStud = from stud in students
                             orderby stud.FirstName descending, stud.LastName descending
                                select stud;


            var sortedStudsSec = students.OrderByDescending(st => st.FirstName).ThenBy(st => st.FirstName).
                               ThenBy(st => st.LastName);
       
            PrintCollection(sortedStud);


            //Problem 6 

            Console.WriteLine("Problem 6. Filter students by email domain");

            var studentsByMail = from stud in students
                where stud.Email.Contains("abv.bg")
                select stud.Email;

            var studentsByMailsec =students.Where(student => student.Email.Contains("abv.bg")) ;
            PrintCollection(studentsByMail);

            //Problem 7

            Console.WriteLine("Problem 7. Filter students by phone");

            var studentsByPhone = from stud in students
                                where stud.Phone.StartsWith("02")
                                select stud.Phone;

            var studentsByPhoneSec = students.Where(student => student.Phone.StartsWith("02"));

            PrintCollection(studentsByPhone);
            Console.WriteLine();


            //Problem 8
            Console.WriteLine("Problem 8. Excellent Students");

            var ExcellentStuds = from stud in students
                where stud.Marks.Contains(6)
                select new {stud.FirstName, stud.LastName, Marks = string.Join(" ",stud.Marks)};

            var excellentStudents =
                students.Where(stud => stud.Marks.Contains(6))
                    .Select(st => new {st.FirstName, st.LastName, Marks = string.Join(" ", st.Marks)});
            PrintCollection(ExcellentStuds);
            Console.WriteLine();

            // Prob 9
            Console.WriteLine("Problem 9.	Weak Students");

            var weakStudents = students.Where(stud => stud.Marks.Count(x => x == 2) == 2);
            PrintCollection(weakStudents);
            Console.WriteLine();

            // Prob 10
            Console.WriteLine("Problem 10.	Students Enrolled in 2014");
            var enroledIn2014 =
                from st in students
                where (st.FacultyNumber % 100 == 14)
                select st;
            var joned2014 =
                students.Where(st => st.FacultyNumber % 100 == 14)
                    .Select(st => new { st.FirstName, st.LastName, st.FacultyNumber });
            PrintCollection(joned2014);
            Console.WriteLine();
        }

         static void PrintCollection(IEnumerable collection)
        {
            foreach (var varr in collection)
            {
                Console.WriteLine(varr);
            }
        }
    }
}