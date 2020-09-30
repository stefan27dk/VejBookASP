using System;
using System.Collections.Generic;
using System.Text;

namespace VejBookASP.Domain.Model
{
    public class Hold
    {
        // Props
        public Guid Id { get;}


        public Hold(Guid id)  // Constructor
        {
            Id = id;
        }
    }
}
