using ConsultantApp.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Persons
{
    public class Person: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
