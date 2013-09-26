using Store.Domain.Abstract;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Products);
        }
        public ViewResult Edit(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("Единица товара -={0}=- сохранена", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // что то не так с данными
                return View(product);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Product());
        }
        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product prod = repository.Products.FirstOrDefault(p => p.ProductID == productId);
            if (prod != null)
            {
                repository.DeleteProduct(prod);
                TempData["message"] = string.Format("Позиция товара -={0}=- была удалена", prod.Name); 
            }
            return RedirectToAction("Index");
        }
    }
}
