using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using VejBookASP.Domain.Model;

namespace VejBookASP.Database
{
   public class DbInitializer
    {
        // TEST DATA----------!!!--------!!!!!!!!----------------!!!!!!---------------!!!!!!!!!!!!!
        public static void Initialize(VejBookContext context)
        {
            //context.Database.EnsureCreated();
           
            // Look for any students
            if(context.Students.Any())
            {
                return;
            }




            // Add Students        
            var students = new Student[]
            {
            new Student(new Guid(), "Carson","Alexander"),
            new Student(new Guid(), "Bob","Alex"),
            new Student(new Guid(), "Georgi","Pop"),
            new Student(new Guid(), "Stacko","Pusho"),
            new Student(new Guid(), "Tosho","TT"),
            new Student(new Guid(), "Bado","Hako"),
            new Student(new Guid(), "dd","ff"),
           
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();





            // Add Teacher        
            var teachers = new Teacher[]
            {
            new Teacher(new Guid(), "Tomy","Cat"),
            new Teacher(new Guid(), "Jerry","Mouse"),
            new Teacher(new Guid(), "Zajak","Alex"),
            new Teacher(new Guid(), "Vulk","Tosho"),    
            };

            foreach (Teacher s in teachers)
            {
                context.Teachers.Add(s);
            }
            context.SaveChanges();








            // Add Holds        
            var Holds = new Hold[]
            {
            new Hold(new Guid()),
            new Hold(new Guid()),
            new Hold(new Guid()),
            new Hold(new Guid()),
            new Hold(new Guid()),   
            };

            foreach (Hold s in Holds)
            {
                context.Holds.Add(s);
            }
            context.SaveChanges();






            // Add Timeslot        
            var Timeslots = new Timeslot[]
            {
            new Timeslot(new Guid()),
            new Timeslot(new Guid()),
            new Timeslot(new Guid()),
            new Timeslot(new Guid()),   
            };

            foreach (Timeslot s in Timeslots)
            {
                context.Timeslots.Add(s);
            }
            context.SaveChanges();

        }

    }
}
                    