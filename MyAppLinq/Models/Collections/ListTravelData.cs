using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAppLinq.Models.Collections
{
    public class ListTravelData
    {
        public static List<Travel> ListTravel = new List<Travel>
        {
            new Travel(1, "Sous le soleil des tropiques", 1000, 1),
            new Travel(2, "Aurora borealis", 1500, 2),
            new Travel(3, "West cost yeah", 3000, 2),
            new Travel(4, "Sera perche ti amo", 500, 1),
            new Travel(5, "Vive la Grèce", 800, 3),
            new Travel(6, "Super week-end en Aveyron", 150, 4),
            new Travel(7, "Tour du Monde", 30000, 5),
            new Travel(8, "Narbonne beach", 50, 6),
            new Travel(9, "Aloha stitch", 10000, 7)
        };
    }
}