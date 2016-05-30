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
        public ActionResult AddPricesForSupplier()
        {
            //get list SupplierId
            SupplierService supplier = new SupplierService();
            var listSupplier = supplier.GetAll();
            List<SelectListItem> listSupplierId = new List<SelectListItem>();
            foreach (var sup in listSupplier)
            {
                listSupplierId.Add(new SelectListItem() { Value = sup.Id.ToString(), Text = sup.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["SupplierId"] = listSupplierId;

            FabricsColorService fabricsColor = new FabricsColorService();
            var listFabricsColor = fabricsColor.GetAll();
            List<SelectListItem> listFabricsColorId = new List<SelectListItem>();
            foreach (var fab in listFabricsColor)
            {
                listFabricsColorId.Add(new SelectListItem() { Value = fab.Id.ToString(), Text = fab.ColorName, Selected = true });
            }

            @ViewData["fabricsColorId"] = listFabricsColorId;

            return View();
        }

        public ActionResult AddPricesForCustomer()
        {
            //get list Customer
            CustomerService customer = new CustomerService();
            var listCustomer = customer.GetAll();
            List<SelectListItem> listCustomerId = new List<SelectListItem>();
            foreach (var cus in listCustomer)
            {
                listCustomerId.Add(new SelectListItem() { Value = cus.Id.ToString(), Text = cus.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["CustomerId"] = listCustomerId;

            FabricsColorService fabricsColor = new FabricsColorService();
            var listFabricsColor = fabricsColor.GetAll();
            List<SelectListItem> listFabricsColorId = new List<SelectListItem>();
            foreach (var fab in listFabricsColor)
            {
                listFabricsColorId.Add(new SelectListItem() { Value = fab.Id.ToString(), Text = fab.ColorName, Selected = true });
            }

            @ViewData["fabricsColorId"] = listFabricsColorId;

            return View();
        }

        public ActionResult AddDelivery()
        {
            //get list ShiperId
            EmployeeService employee = new EmployeeService();
            var listEmployee = employee.GetShipper();
            List<SelectListItem> listEmployeeId = new List<SelectListItem>();
            foreach (var emp in listEmployee)
            {
                listEmployeeId.Add(new SelectListItem() { Value = emp.Id.ToString(), Text = emp.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["ShipperId"] = listEmployeeId;

            //get list ShiperId
            SalesInvoiceService salesInvoiceService = new SalesInvoiceService();
            var listSalesInvoice = salesInvoiceService.GetAll();
            List<SelectListItem> listSalesInvoiceId = new List<SelectListItem>();
            foreach (var sales in listSalesInvoice)
            {
                listSalesInvoiceId.Add(new SelectListItem() { Value = sales.Id.ToString(), Text = sales.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["SalesInvoiceId"] = listSalesInvoiceId;

            return View();

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddPricesForSupplier(Prices pricess,string id)
        {
            SupplierService supplier = new SupplierService();

            supplier.AddFabricsPrice(id, pricess);

            return RedirectToAction("ViewSupplier", "Show");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddPricesForCustomer(Prices pricess, string id)
        {
            CustomerService customer = new CustomerService();

            customer.AddFabricsPrice(id, pricess);

            return RedirectToAction("ViewCustomer", "Show");
        }

        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddDelivery(Delivery delivery, string salesInvoiceId)
        {
           SalesInvoiceService salesInvoiceService = new SalesInvoiceService();

           salesInvoiceService.AddDelivery(salesInvoiceId, delivery);

            return RedirectToAction("ViewSalesInvoice", "Show");
        }

    }
}
