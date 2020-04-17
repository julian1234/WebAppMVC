using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class VENDEDOR_APIController : ApiController
    {
        private DB_A56C50_admin759Entities db = new DB_A56C50_admin759Entities();

        // GET: api/VENDEDOR_API
        public IQueryable<VENDEDOR> GetVENDEDOR()
        {
            return db.VENDEDOR;
        }

        // GET: api/VENDEDOR_API/5
        [ResponseType(typeof(VENDEDOR))]
        public IHttpActionResult GetVENDEDOR(int id)
        {
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return NotFound();
            }

            return Ok(vENDEDOR);
        }

        // PUT: api/VENDEDOR_API/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVENDEDOR(int id, VENDEDOR vENDEDOR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vENDEDOR.CODIGO)
            {
                return BadRequest();
            }

            db.Entry(vENDEDOR).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VENDEDORExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VENDEDOR_API
        [ResponseType(typeof(VENDEDOR))]
        public IHttpActionResult PostVENDEDOR(VENDEDOR vENDEDOR)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VENDEDOR.Add(vENDEDOR);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vENDEDOR.CODIGO }, vENDEDOR);
        }

        // DELETE: api/VENDEDOR_API/5
        [ResponseType(typeof(VENDEDOR))]
        public IHttpActionResult DeleteVENDEDOR(int id)
        {
            VENDEDOR vENDEDOR = db.VENDEDOR.Find(id);
            if (vENDEDOR == null)
            {
                return NotFound();
            }

            db.VENDEDOR.Remove(vENDEDOR);
            db.SaveChanges();

            return Ok(vENDEDOR);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VENDEDORExists(int id)
        {
            return db.VENDEDOR.Count(e => e.CODIGO == id) > 0;
        }
    }
}