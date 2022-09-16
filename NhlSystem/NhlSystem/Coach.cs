using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
    public class Coach : Person
    {
        public DateTime HireDate { get; set; }


        // Define an auto-implemented property for HireDate with a private set
        public Coach(string fullName, DateTime hireDate) : base(fullName)
        {
            HireDate = hireDate;
        }
    }
}
