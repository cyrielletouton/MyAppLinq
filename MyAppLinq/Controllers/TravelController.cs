using MyAppLinq.Models.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAppLinq.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travels
        public ActionResult Travels()
        {
            //DataSource
            var maliste = ListTravelData.ListTravel;

            //Definir notre requête
            var TravelDefinitionQueryMethod = maliste
                .Select(travel => $"Voyage n°{travel.TravelId} : {travel.Name}");

            ViewBag.Travels = TravelDefinitionQueryMethod;
            return View();
           
        }

        // GET: Travels with maximum cost
        public ActionResult TravelsMaxCost(int cost)
        {
            var maliste = ListTravelData.ListTravel;

            var rechercheQuery =
                from travel in maliste
                where travel.Cost < cost
                orderby travel.Cost ascending
                select $"Tu peux aller à {travel.Name}, voyage qui coute {travel.Cost} euros.";

            ViewBag.Travels = rechercheQuery;
            return View();

        }

        // POST: Create a new trip
        [HttpPost]
        public ActionResult Create(Travel travel)
        {
            string name = travel.Name;
            int cost = travel.Cost;
            int personId = travel.PersonId;

            try
            {
                var maliste = ListTravelData.ListTravel;
                maliste.Add(new Travel(maliste.Count + 1, name, cost, personId));

                return RedirectToAction("Travels");
            }
            catch
            {
                return View();
            }
        }

        // See which trip a participant is registered for
        public ActionResult Registered(string name)
        {
            var malisteTravel = ListTravelData.ListTravel;
            var malistePerson = ListPersonData.ListPerson;

            var request = from person in malistePerson
                          where person.Name.Contains(name)
                          join travel in malisteTravel on person.PersonId equals travel.PersonId
                          select $"{person.Name} est inscrit à : {travel.Name}.";

            ViewBag.Registered = request;
            return View();
        }
    }
}