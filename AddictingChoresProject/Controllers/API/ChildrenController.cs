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
using AddictingChoresProject.DAL;
using AddictingChoresProject.Models;

namespace AddictingChoresProject.Controllers.API
{
    public class ChildrenController : ApiController
    {
        private AddictingChoresContext db = new AddictingChoresContext();

        // GET: api/Children
        public IQueryable<Child> GetChildren()
        {
            return db.Children;
        }

        // GET: api/Children/5
        [ResponseType(typeof(Child))]
        public IHttpActionResult GetChild(int id)
        {
            Child child = db.Children.Find(id);
            if (child == null)
            {
                return NotFound();
            }

            return Ok(child);
        }

        // PUT: api/Children/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChild(int id, Child child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != child.ChildId)
            {
                return BadRequest();
            }

            db.Entry(child).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChildExists(id))
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

        // POST: api/Children
        [ResponseType(typeof(Child))]
        public IHttpActionResult PostChild(Child child)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Children.Add(child);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = child.ChildId }, child);
        }

        // DELETE: api/Children/5
        [ResponseType(typeof(Child))]
        public IHttpActionResult DeleteChild(int id)
        {
            Child child = db.Children.Find(id);
            if (child == null)
            {
                return NotFound();
            }

            db.Children.Remove(child);
            db.SaveChanges();

            return Ok(child);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChildExists(int id)
        {
            return db.Children.Count(e => e.ChildId == id) > 0;
        }
    }
}