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
            FabricsService fabricsService = new FabricsService();
            var listFabrics = fabricsService.GetAll();
            List<SelectListItem> listId = new List<SelectListItem>();
            foreach (var fabrics in listFabrics)
            {
                listId.Add(new SelectListItem() { Value = fabrics.Id.ToString(), Text = fabrics.Id.Increment.ToString(), Selected = true });
            }
            
            @ViewData["id"] = listId;
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

        public ActionResult CreateSalesOrder()
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

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSalesOrder(SalesOrder models)
        {
            SalesOrderService salesOrder = new SalesOrderService();


            salesOrder.Create(models);

            return RedirectToAction("ViewSalesOrder", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFabrics(Fabrics models)
        {
            FabricsService fabrics = new FabricsService();


            fabrics.Create(models);

            return RedirectToAction("ViewFabrics", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFabricsColor(FabricsColor models)
        {
            FabricsColorService fabricsColor = new FabricsColorService();

            fabricsColor.Create(models);

            return RedirectToAction("ViewFabrics", "Show");

        }
    }
}
