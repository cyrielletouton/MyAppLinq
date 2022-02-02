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
            //Syntaxe méthode
            var TravelDefinitionQueryMethod = maliste
                .Select(travel => $"Travel n°{travel.TravelId} : {travel.Name}");

            ViewBag.Travels = TravelDefinitionQueryMethod;
            return View();
           
        }

        // GET: Travels with maximum cost
        public ActionResult TravelsMaxCost(int cost)
        {
            //DataSource
            var maliste = ListTravelData.ListTravel;

            //Definir notre requête
            //Syntaxe méthode
            var rechercheQuery =
                from travel in maliste
                where travel.Cost < cost
                orderby travel.Cost ascending
                select $"Tu peux aller à {travel.Name}, voyage qui coute {travel.Cost} euros.";

            ViewBag.Travels = rechercheQuery;
            return View();

        }
    }
}