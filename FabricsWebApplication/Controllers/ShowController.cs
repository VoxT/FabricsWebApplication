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
            foreach(var sup in model)
            {
                @ViewData[sup.Id.ToString()] = supplier.GetDebt(sup.Id.ToString());
            }
           
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

        public ActionResult ViewPurchaseOrder()
        {
            PurchaseOrderService purchaseOrder = new PurchaseOrderService();

            List<PurchaseOrder> model = new List<PurchaseOrder>();

            model = purchaseOrder.GetAll();

            return View(model);
        }

        public ActionResult ViewPurchaseInvoice()
        {
            PurchaseInvoiceService purchaseInvoice = new PurchaseInvoiceService();

            List<PurchaseInvoice> model = new List<PurchaseInvoice>();

            model = purchaseInvoice.GetAll();
            List<Double> listTotalMoney = new List<Double>();
            foreach (var ex in model)
            {
                @ViewData[ex.SupplierId.ToString()] = purchaseInvoice.GetTotalMoney(ex);
            }
           
            return View(model);
        }

        public ActionResult ViewPayment()
        {
            PaymentService payment = new PaymentService();

            List<Payment> model = new List<Payment>();

            model = payment.GetAll();

            return View(model);
        }

        public ActionResult ViewRecord()
        {
            RecordService record = new RecordService();

            List<Record> model = new List<Record>();

            model = record.GetAll();

            return View(model);
        }

        public ActionResult ViewFabrics()
        {
            FabricsService fabrics = new FabricsService();

            List<Fabrics> model = new List<Fabrics>();

            model = fabrics.GetAll();

            return View(model);
        }

        public ActionResult ViewFabricsColor()
        {
            FabricsColorService fabricsColor = new FabricsColorService();

            List<FabricsColor> model = new List<FabricsColor>();

            model = fabricsColor.GetAll();

            return View(model);
        }

        public ActionResult ViewFabricsRoll()
        {
            FabricsRollService fabricsRoll = new FabricsRollService();

            List<FabricsRoll> model = new List<FabricsRoll>();

            model = fabricsRoll.GetAll();

            return View(model);
        }

        public ActionResult ViewFabricsPlots()
        {
            FabricsPlotsService fabricsPlots = new FabricsPlotsService();

            List<FabricsPlots> model = new List<FabricsPlots>();

            model = fabricsPlots.GetAll();

            return View(model);
        }

        public ActionResult ViewWareHouse()
        {
            WareHouseService wareHouse = new WareHouseService();

            List<WareHouse> model = new List<WareHouse>();

            model = wareHouse.GetAll();

            return View(model);
        }
       
    }
}
