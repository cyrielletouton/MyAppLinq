using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyAppLinq.Controllers
{
    public class APIController : Controller
    {
        // GET: Countries
        public ActionResult AllCountries()
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString("https://travelbriefing.org/countries.json");
            var arrayCountries = JArray.Parse(json);

            var allCountries = from country in arrayCountries
                               select country;

            ViewBag.Countries = allCountries;
            return View();
        }

        // GET: Country
        public ActionResult Country(string name)
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString("https://travelbriefing.org/" + name + "?format=json");
            var jsonCountry = JObject.Parse(json);

            ViewBag.Country = jsonCountry;
            return View();
        }

        // GET: Europe Countries
        public ActionResult AllEuropeCountries()
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString("https://travelbriefing.org/countries.json");
            var arrayCountries = JArray.Parse(json);

            var allCountries = from country in arrayCountries
                                //where country["url"].Values("timezone").Contains("Europe")
                               select country["url"];

            ViewBag.Countries = allCountries;
            return View();
        }
    }
}
