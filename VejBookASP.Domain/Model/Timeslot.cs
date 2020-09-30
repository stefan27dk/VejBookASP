using System;
using System.Collections.Generic;
using System.Text;

namespace VejBookASP.Domain.Model
{
    public  class Timeslot
    {
        //Props
        public Guid Id { get;}
        public BCalendar BCalendar { get;}

        public Timeslot(Guid id, BCalendar bCalendar)   // Constructor
        {
            Id = id;
            BCalendar = bCalendar;
        }

   
    }
}
