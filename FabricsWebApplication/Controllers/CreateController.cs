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
        public ActionResult Create()
        {
            Connection connect = new Connection();

            return View();
        }


        public ActionResult CreateCustomer()
        {
            return View();
        }

        public ActionResult CreateSupplier()
        {
            return View();
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        public ActionResult CreateInvoice()
        {
            return View();
        }

        public ActionResult CreateFabrics()
        {
            return View();
        }

        public ActionResult CreateFabricsColor()
        {
            return View();
        }

        public ActionResult CreateFabricsPlots()
        {
            return View();
        }

        public ActionResult CreateFabricsRoll()
        {
            return View();
        }

        public ActionResult CreateGoods()
        {
            return View();
        }

        public ActionResult CreateGoodsreturn()
        {
            return View();
        }

        public ActionResult CreateLeave()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public ActionResult CreatePayment()
        {
            return View();
        }

        public ActionResult CreateRecord()
        {
            return View();
        }

        public ActionResult CreateWareHouse()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public ActionResult CreateCustomer(Customer models)
        {
           Connection connect = new Connection();
           
            CustomerService customer = new CustomerService();
            

            customer.Create(models);

            return RedirectToAction("ViewCustomer", "Show");
         
        }

        //create Sipplier

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSupplier(Supplier models)
        {
            SupplierService supplier = new SupplierService();

            supplier.Create(models);

            return RedirectToAction("ViewSupplier", "Show");

        }
        /// <summary>
        /// create Employee
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee(Employee models)
        {
            EmloyeeService employee = new EmloyeeService();

           
            employee.Create(models);

            return RedirectToAction("ViewEmployee", "Show");

        }
        
    }
}
