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

namespace SalesSys.Controllers
{
    public class SalesController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: Sales
        public async Task<ActionResult> Index()
        {
            return View(await db.Sales.ToListAsync());
        }
        
        // GET: Sales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Amount,Value,Date", Exclude="IdSale")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Sales.Add(sale);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sale);
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
