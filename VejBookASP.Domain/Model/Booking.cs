using System;
using System.Collections.Generic;
using System.Text;

namespace VejBookASP.Domain.Model
{
    public class Booking
    {
        public Guid Id { get; }

        public Booking(Guid id) // Constructor
        {
            Id = id;
        }
    }
}
