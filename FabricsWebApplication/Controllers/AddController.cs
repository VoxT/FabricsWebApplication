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
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddPricesForSupplier(Prices pricess,string id)
        {
            SupplierService supplier = new SupplierService();

            supplier.AddFabricsPrice(id, pricess);

            return RedirectToAction("ViewSupplier", "Show");
        }
    }
}
