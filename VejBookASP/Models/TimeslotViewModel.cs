using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VejBookASP.Domain.Model;

namespace VejBookASP.Models
{
    public class TimeslotViewModel
    {

        public Guid Id { get; set; }

     
        public BCalendar BCalendar { get; set; }

    }
}
