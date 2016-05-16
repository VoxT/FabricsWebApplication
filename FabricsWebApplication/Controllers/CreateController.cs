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
    public class CreateController : Controller
    {
        public ActionResult Index()
        {

            Example ex = new Example
            {
                FirstName = "Thieu",
                Age = 22,
                LastName = "Tran"
            };
            ExampleService example = new ExampleService();
            example.Create(ex);

            @ViewBag.Message = example.GetAll().FirstOrDefault().Id;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Customer models)
        {
           Connection connect = new Connection();

           // connect.CreateConnection();

           // var model = new List<Customer>();
            //ExampleService example = new ExampleService();
            CustomerService customer = new CustomerService();
            customer.Create(models);


            return RedirectToAction("ViewExample", "Create");
            //return View(models);
        }

        public ActionResult ViewExample()
        {


            CustomerService example = new CustomerService();

            List<Customer> model = new List<Customer>();
            model = example.GetAll();
           // Console.WriteLine(model.ToString());
            return View(model);
        }
        public ActionResult AddPrices()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddPrices(Prices price) 
        {
            Connection connect = new Connection();

            // connect.CreateConnection();

            // var model = new List<Customer>();
            //ExampleService example = new ExampleService();
            CustomerService customer = new CustomerService();
            var id = customer.GetAll().FirstOrDefault().Id;
            customer.AddFabricsPrice(id, price);

            return RedirectToAction("ViewExample", "Create");
        }
    }
}
