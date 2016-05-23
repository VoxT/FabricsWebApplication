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
    public class ShowController : Controller
    {
        
        public ActionResult View1()
        {
            return View();
        }

        public ActionResult ViewCustomer()
        {
            CustomerService customer = new CustomerService();

            List<Customer> model = new List<Customer>();

            model = customer.GetAll();

            return View(model);
        }

        public ActionResult ViewSupplier()
        {
            SupplierService supplier = new SupplierService();

            List<Supplier> model = new List<Supplier>();

            model = supplier.GetAll();
           
            return View(model);
        }

        public ActionResult ViewEmployee()
        {
            EmloyeeService employee = new EmloyeeService();

            List<Employee> model = new List<Employee>();

            model = employee.GetAll();

            return View(model);
        }

        public ActionResult ViewSalesOrder()
        {
            SalesOrderService salesOrder = new SalesOrderService();

            List<SalesOrder> model = new List<SalesOrder>();

            model = salesOrder.GetAll();

            return View(model);
        }

        public ActionResult ViewFabrics()
        {
            FabricsService fabrics = new FabricsService();

            List<Fabrics> model = new List<Fabrics>();

            model = fabrics.GetAll();

            return View(model);
        }
        
    }
}
