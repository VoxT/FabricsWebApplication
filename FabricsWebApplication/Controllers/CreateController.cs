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

        public ActionResult CreatePurchaseInvoice()
        {
            //get list EmployeeId
            EmloyeeService employee = new EmloyeeService();
            var listEmployee = employee.GetAll();
            List<SelectListItem> listEmployeeId = new List<SelectListItem>();
            foreach (var emp in listEmployee)
            {
                listEmployeeId.Add(new SelectListItem() { Value = emp.Id.ToString(), Text = emp.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["EmployeeId"] = listEmployeeId;

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

            //Get list purchaseOrder
            PurchaseOrderService purchaseOrderService = new PurchaseOrderService();
            var listOrderInvoice = purchaseOrderService.GetAll();
            List<SelectListItem> listOrderInvoiceId = new List<SelectListItem>();
            foreach (var purchaseOrder in listOrderInvoice)
            {
                listOrderInvoiceId.Add(new SelectListItem() { Value = purchaseOrder.Id.ToString(), Text = purchaseOrder.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["PurchaseOrderId"] = listOrderInvoiceId;

            //Get list WareHouseId
            WareHouseService wareHouseService = new WareHouseService();
            var listWareHouse = wareHouseService.GetAll();
            List<SelectListItem> listWareHouseId = new List<SelectListItem>();
            foreach (var wareHouse in listWareHouse)
            {
                listWareHouseId.Add(new SelectListItem() { Value = wareHouse.Id.ToString(), Text = wareHouse.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["WareHouseId"] = listWareHouseId;

            return View();
        }

        public ActionResult CreateSalesInvoice()
        {

            return View();
        }

        public ActionResult CreateFabrics()
        {
            return View();
        }

        public ActionResult CreateFabricsColor()
        {
            //get list fabricsId
            FabricsService fabricsService = new FabricsService();
            var listFabrics = fabricsService.GetAll();
            List<SelectListItem> listId = new List<SelectListItem>();
            foreach (var fabrics in listFabrics)
            {
                listId.Add(new SelectListItem() { Value = fabrics.Id.ToString(), Text = fabrics.Name, Selected = true });
            }
            //return to view
            @ViewData["id"] = listId;
            return View();
        }

        public ActionResult CreateFabricsPlots()
        {
            return View();
        }

        public ActionResult CreateFabricsRoll()
        {
            //get list PurnchaseInvoiceId
            PurchaseInvoiceService purchaseInvoiceService = new PurchaseInvoiceService();
            var listPurchaseInvoice = purchaseInvoiceService.GetAll();
            List<SelectListItem> listPurchaseInvoiceId = new List<SelectListItem>();
            foreach (var purchaseInvoice in listPurchaseInvoice)
            {
                listPurchaseInvoiceId.Add(new SelectListItem() { Value = purchaseInvoice.Id.ToString(), Text = purchaseInvoice.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["purchaseInvoiceId"] = listPurchaseInvoiceId;
           
            //get list FabricsColorId
            FabricsColorService fabricsColorService = new FabricsColorService();
            var listFabricsColor = fabricsColorService.GetAll();
            List<SelectListItem> listFabricsColorId = new List<SelectListItem>();
            foreach (var fabricsColor in listFabricsColor)
            {
                listFabricsColorId.Add(new SelectListItem() { Value = fabricsColor.Id.ToString(), Text = fabricsColor.ColorName, Selected = true });
            }
            //return to view
            @ViewData["fabricsColorId"] = listFabricsColorId;

            //get list FabricsPlotsId
            FabricsPlotsService fabricsPlotsService = new FabricsPlotsService();
            var listFabricsPlots = fabricsPlotsService.GetAll();
            List<SelectListItem> listFabricsPlotsId = new List<SelectListItem>();
            foreach (var fabricsPlots in listFabricsPlots)
            {
                listFabricsPlotsId.Add(new SelectListItem() { Value = fabricsPlots.Id.ToString(), Text = fabricsPlots.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["fabricsPlotsId"] = listFabricsPlotsId;
           

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
            CustomerService customer = new CustomerService();
            var listCustomer = customer.GetAll();
            List<SelectListItem> listCustomerId = new List<SelectListItem>();
            foreach (var cus in listCustomer)
            {
                listCustomerId.Add(new SelectListItem() { Value = cus.Id.ToString(), Text = cus.Id.Increment.ToString(), Selected = true });
            }

            @ViewData["CustomerId"] = listCustomerId;

            FabricsColorService fabricsColor = new FabricsColorService();
            var listFabricsColor = fabricsColor.GetAll();
            List<SelectListItem> listFabricsColorId = new List<SelectListItem>();
            foreach (var fab in listFabricsColor)
            {
                listFabricsColorId.Add(new SelectListItem() { Value = fab.Id.ToString(), Text = fab.ColorName, Selected = true });
            }

            @ViewData["FabricsColorId"] = listFabricsColorId;

            return View();
        }

        public ActionResult CreatePurchaseOrder()
        {
            //get list EmployeeId
            EmloyeeService employee = new EmloyeeService();
            var listEmployee = employee.GetAll();
            List<SelectListItem> listEmployeeId = new List<SelectListItem>();
            foreach (var emp in listEmployee)
            {
                listEmployeeId.Add(new SelectListItem() { Value = emp.Id.ToString(), Text = emp.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["EmployeeId"] = listEmployeeId;

            //get list FabricsColorId
            FabricsColorService fabricsColor = new FabricsColorService();
            var listFabricsColor = fabricsColor.GetAll();
            List<SelectListItem> listFabricsColorId = new List<SelectListItem>();
            foreach (var fab in listFabricsColor)
            {
                listFabricsColorId.Add(new SelectListItem() { Value = fab.Id.ToString(), Text = fab.ColorName, Selected = true });
            }
            //return to view
            @ViewData["FabricsColorId"] = listFabricsColorId;

            return View();
        }


        public ActionResult CreatePaymentForSupplier()
        {
            //get list EmployeeId
            EmloyeeService employee = new EmloyeeService();
            var listEmployee = employee.GetAll();
            List<SelectListItem> listEmployeeId = new List<SelectListItem>();
            foreach (var emp in listEmployee)
            {
                listEmployeeId.Add(new SelectListItem() { Value = emp.Id.ToString(), Text = emp.Id.Increment.ToString(), Selected = true });
            }
            //return to view
            @ViewData["EmployeeId"] = listEmployeeId;

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
         
            List<SelectListItem> listPaymentType = new List<SelectListItem>();
            listPaymentType.Add(new SelectListItem() {Value = "revenues",Text = "revenues" });
            listPaymentType.Add(new SelectListItem() {Value = "expenditures",Text = "expenditures" });
            @ViewData["paymentType"] = listPaymentType;

            List<SelectListItem> listPaymentMethod = new List<SelectListItem>();
            listPaymentMethod.Add(new SelectListItem() { Value = "transfer", Text = "transfer" });
            listPaymentMethod.Add(new SelectListItem() { Value = "cash", Text = "cash" });
            @ViewData["paymentMethod"] = listPaymentMethod;

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
        public ActionResult CreatePurchaseOrder(PurchaseOrder models)
        {
            PurchaseOrderService purchaseOrder = new PurchaseOrderService();

            purchaseOrder.Create(models);

            return RedirectToAction("ViewPurchaseOrder", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePaymentForSupplier(Payment models)
        {
            PaymentService payment = new PaymentService();

            payment.Create(models);

            return RedirectToAction("ViewPayment", "Show");

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

            return RedirectToAction("ViewFabricsColor", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFabricsRoll(FabricsRoll models)
        {
            FabricsRollService fabricsRoll = new FabricsRollService();

            fabricsRoll.Create(models);

            return RedirectToAction("ViewFabricsRoll", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFabricsPlots(FabricsPlots models)
        {
            FabricsPlotsService fabricsPlots = new FabricsPlotsService();


            fabricsPlots.Create(models);

            return RedirectToAction("ViewFabricsPlots", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePurchaseInvoice(PurchaseInvoice models)
        {
            PurchaseInvoiceService purchaseInvoice = new PurchaseInvoiceService ();


            purchaseInvoice.Create(models);

            return RedirectToAction("ViewPurchaseInvoice", "Show");

        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWareHouse(WareHouse models)
        {
            WareHouseService wareHouse = new WareHouseService();


            wareHouse.Create(models);

            return RedirectToAction("ViewWareHouse", "Show");

        }

    }
}
