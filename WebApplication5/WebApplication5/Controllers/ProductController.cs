using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Context;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ProductContext db = new ProductContext();
        public ActionResult Index()
        {

            return View(db.product.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            Product product = new Product();
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            product = db.product.Find(id);
            if (product==null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.product.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            Product product = new Product();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            product = db.product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
          
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int ?id, Product product)
        {
            try
            {

                Product productObj = new Product();
                productObj = db.product.Find(id);
                if (ModelState.IsValid)
                {
                    UpdateModel(productObj);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(productObj);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int ?id)
        {
            Product product = new Product();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            product = db.product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);

        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int ?id, Product product)
        {
            try
            {

               
                product= db.product.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                db.product.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
