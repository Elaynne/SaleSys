using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesSys.Models;
using System.IO;

namespace SalesSys.Controllers
{
    public class ProductsController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: Products
        public async Task<ActionResult> Index()
        {
            var hasItem = await db.Products.ToListAsync();
            ViewBag.HasItem = hasItem.Count() > 0 == true ? true : false;
            
            return View(await db.Products.ToListAsync());
        }
        
        // GET: Products/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Code,Name,Description,Amount,ManufactureDate,PriceString", Exclude = "idProduct")] Product product, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Image.ContentLength > 0)
                    {
                        string[] _type = Image.ContentType.Split('/');
                        string _FileName = Path.GetFileName("product" + (product.IdProduct).ToString() + "." + _type[1]);
                        string _path = Path.Combine(Server.MapPath("~/UploadFile"), _FileName); //localhost=> Server.MapPath("~/UploadedFile"), _FileName);
                        Image.SaveAs(_path);

                        product.Image = (_FileName);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                }
                
                db.Products.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IdProduct,Code,Name,Description,Amount,ManufactureDate,Price")] Product product, HttpPostedFileBase Image)
        {
            product.ManufactureDate = db.Products.Where(ID => ID.IdProduct == product.IdProduct).Select(d => d.ManufactureDate).FirstOrDefault();
            if (ModelState.IsValid)
            {

                try
                {
                    if (Image.ContentLength > 0)
                    {
                        string[] type = Image.ContentType.Split('/');
                        string _FileName = Path.GetFileName("product" + (product.IdProduct).ToString() + "." + type[1]);
                        string _path = Path.Combine(Server.MapPath("~/UploadFile"), _FileName);
                        Image.SaveAs(_path);

                        product.Image = (_FileName);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                }
                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //// GET: Products/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = await db.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        // POST: Products/Delete/5
        [HttpGet, ActionName("Delete")]
        [Route("Products/Delete/{idProduct}")]
       // [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int idProduct)
        {
            Product product = await db.Products.FindAsync(idProduct);
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
