using System;
using System.Collections.Generic;
using System.Linq;
using eCommerce.DAL.Data;
using System.Web;
using eCommerce.DAL.Repositories;
using System.Web.Mvc;
using eCommerce.Contracts.Repositories;
using eCommerce.Model;
using eCommerce.Services;

namespace eCommerce.WebUI.Controllers
{

    public class HomeController : Controller
    {
        IRepositoryBase<Customer> customers;
        IRepositoryBase<Product> products;
        IRepositoryBase<Basket> baskets;

        BasketSerivce basketService;


        public HomeController(IRepositoryBase<Customer> customers, IRepositoryBase<Product> products, IRepositoryBase<Basket> baskets)
        {
            this.customers = customers;
            this.products = products;
            this.baskets = baskets;
            basketService = new BasketSerivce(this.baskets);


        }

        public ActionResult BasketSummary()
        {
            /// comments to checck the commit 

            var model = basketService.GetBasket(HttpContext);

            return View(model.BasketItems);
        }


        public ActionResult AddToBasket(int id)
        {

            basketService.AddToBasket(HttpContext, id, 1);



            return RedirectToAction("BasketSummary");
        }

        public ActionResult Index()
        {


            var productList = products.GetAll();

            return View(productList);
        }

        public ActionResult Details(int id)
        {


            var product = products.GetById(id);

            return View(product);
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AngularTest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}