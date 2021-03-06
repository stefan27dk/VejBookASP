﻿using System;
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
            Validate();
        }


        public ICollection<Hold> Holds { get; set; }






        // Methods::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  

        // Validate
        private void Validate()
        {
            ValidateName();

        }



        // Validate Name 
        private void ValidateName()
        {
            if ((FirstName.Length > 2) && LastName.Length > 2)
            {
                return;
            }
            else
            {
                throw new Exception("Name is too short! This is not your name Exception");
            }
        }
    }
}
