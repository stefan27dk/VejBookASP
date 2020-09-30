using System;
using System.Collections.Generic;
using System.Text;

namespace VejBookASP.Domain.Model
{
   public class Student
    {
        // Props
        public Guid Id{get;}
        public string FirstName {get;}
        public string LastName {get;}


        public Student(Guid id, string firstName, string lastName) // Constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }


        public ICollection<Hold> Holds { get; set; }
    }
}
