using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{ 
    public class Person
    {
        public int? Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Note { get; set; }

  //      public PersonImage Image { get; set; }
    }
}
