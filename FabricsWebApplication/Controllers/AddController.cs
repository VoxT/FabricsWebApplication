using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using FabricsFactoryMethodPattern.Entities;
using FabricsFactoryMethodPattern.Services;

namespace FabricsWebApplication.Controllers
{
    public class AddController : Controller
    {

        public ActionResult Add()
        {

            return View();
        }
        public ActionResult AddPrices()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddPrices(Prices pricess)
        {
            Connection connect = new Connection();

            CustomerService customer = new CustomerService();
            var id = customer.GetAll().FirstOrDefault().Id.ToString();
            // price.FabricsColorId = new ObjectId();
            Prices p = new Prices
            {
                Price = pricess.Price,
                FabricsColorId = new ObjectId()
            };
            customer.AddFabricsPrice(id, p);

            return RedirectToAction("ViewCustomer", "Show");
        }
    }
}
