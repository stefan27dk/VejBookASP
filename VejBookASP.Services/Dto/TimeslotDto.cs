using System;
using System.Collections.Generic;
using System.Text;
using VejBookASP.Domain.Model;

namespace VejBookASP.Services.Dto
{
    public class TimeslotDto
    {

        public Guid Id { get; }
                                   
        public BCalendar BCalendar { get; set; }
    }
}
