using EFCoreTutorials.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var context = new SchoolContext())
            //{

            //    var std = new Student()
            //    {
            //        Name = "Bill"
            //    };

            //    List<Student> Studets = new List<Student>()
            //    {
            //        new Student{Name="Naidu" },
            //    new Student { Name = "Sukanya" }
            //};

            //    context.Students.AddRange(Studets);
            //    context.SaveChanges();
            //}

            //var context = new SchoolContext();
            //var studentsWithSameName = context.Students
            //                      .Where(s => s.Name == GetName());

            //    foreach(var item in studentsWithSameName)
            //    {
            //    Console.WriteLine(item.Name);
            //    }
            //Console.ReadLine();
            //var context = new SchoolContext();
            //var std = context.Students.First<Student>();
            //std.Name = "Steve";
            //context.SaveChanges();


        }
        public static string GetName()
        {
            return "Bill";
        }
    }
}
