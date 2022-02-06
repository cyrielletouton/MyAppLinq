using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppLinq.Models.Collections
{
    public class Travel
    {
        public int TravelId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int PersonId { get; set; }

        public Travel(int travelId, string name, int cost, int personId)
        {
            TravelId = travelId;
            Name = name;
            Cost = cost;
            PersonId = personId;
        }

        public Travel() { }
    }
}