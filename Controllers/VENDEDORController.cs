using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class VENDEDORController : Controller
    {
        private DB_A56C50_admin759Entities db = new DB_A56C50_admin759Entities();

        // GET: VENDEDOR
        public ActionResult Index()
        {
            var vENDEDOR = db.VENDEDOR.Include(v => v.CIUDAD);
            return View(vENDEDOR.ToList());
        }

        // GET: VENDEDOR/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDEDOR);
        }

        // GET: VENDEDOR/Create
        public ActionResult Create()
        {
            ViewBag.CODIGO_CIUDAD = new SelectList(db.CIUDAD, "CODIGO", "DESCRIPCION");
            return View();
        }

        // POST: VENDEDOR/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGO,NOMBRE,APELLIDO,NUMERO_IDENTIFICACION,CODIGO_CIUDAD")] VENDEDOR vENDEDOR)
        {
            if (ModelState.IsValid)
            {
                db.VENDEDOR.Add(vENDEDOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODIGO_CIUDAD = new SelectList(db.CIUDAD, "CODIGO", "DESCRIPCION", vENDEDOR.CODIGO_CIUDAD);
            return View(vENDEDOR);
        }

        // GET: VENDEDOR/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODIGO_CIUDAD = new SelectList(db.CIUDAD, "CODIGO", "DESCRIPCION", vENDEDOR.CODIGO_CIUDAD);
            return View(vENDEDOR);
        }

        // POST: VENDEDOR/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGO,NOMBRE,APELLIDO,NUMERO_IDENTIFICACION,CODIGO_CIUDAD")] VENDEDOR vENDEDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vENDEDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODIGO_CIUDAD = new SelectList(db.CIUDAD, "CODIGO", "DESCRIPCION", vENDEDOR.CODIGO_CIUDAD);
            return View(vENDEDOR);
        }

        // GET: VENDEDOR/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDEDOR);
        }

        // POST: VENDEDOR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            db.VENDEDOR.Remove(vENDEDOR);
            db.SaveChanges();
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
