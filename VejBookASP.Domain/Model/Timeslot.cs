using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace VejBookASP.Domain.Model
{
    public  class Timeslot
    {
        //Props
        public Guid Id { get;}

        [NotMapped]
        public BCalendar BCalendar { get; set; }

        public Timeslot(Guid id)   // Constructor
        {
            Id = id;      
        }

   
    }
}
