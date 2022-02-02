using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppLinq.Models.Collections
{
    public class Person
    {
        public Person(int personId, string name)
        {
            PersonId = personId;
            Name = name;
        }
        public int PersonId { get; set; }
        public string Name { get; set; }
    }
}