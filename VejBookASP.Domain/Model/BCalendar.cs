using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VejBookASP.Domain.Model
{
    public class BCalendar
    {
        // Props   
        public Guid Id { get; }


        public BCalendar(Guid id)  // Constructor
        {
            Id = id;
        }


        public ICollection<Hold> Holds { get; set; }
    }
}
