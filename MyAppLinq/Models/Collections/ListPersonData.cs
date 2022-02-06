using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppLinq.Models.Collections
{
    public class ListPersonData
    {
        public static List<Person> ListPerson = new List<Person>
        {
            new Person(1, "Cyrielle"),
            new Person(2, "Matthieu"),
            new Person(3, "Victor"),
            new Person(4, "Raphael"),
            new Person(5, "Marie"),
            new Person(6, "Nathan"),
            new Person(7, "Laurie"),
            new Person(8, "Thomas"),
            new Person(9, "Damien"),
            new Person(10, "Maxime")
        };
    }
}