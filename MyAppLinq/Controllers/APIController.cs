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
            //name = Request["SimpleProp1"];
            var json = webClient.DownloadString("https://travelbriefing.org/" + name + "?format=json");
            var jsonCountry = JObject.Parse(json);

            //var allCountries = from country in arrayCountries
            //                   select country;

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
                                   select country;

            ViewBag.Countries = allCountries;
            return View();
        }

        // GET: API/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: API/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: API/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: API/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: API/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: API/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
