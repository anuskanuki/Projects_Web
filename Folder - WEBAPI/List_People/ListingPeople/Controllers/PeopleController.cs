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
using ListingPeople.Models;

namespace ListingPeople.Controllers
{
    public class PeopleController : ApiController
    {
        private PeopleContext db = new PeopleContext();

        // GET: api/People
        public IQueryable<People> GetPeoples()
        {
            return db.Peoples;
        }

        // GET: api/People/5
        [ResponseType(typeof(People))]
        public IHttpActionResult GetPeople(int id)
        {
            People people = db.Peoples.Find(id);
            if (people == null)
            {
                return NotFound();
            }

            return Ok(people);
        }

        [HttpGet]
        [Route("Api/Peoples/Order")]
        public IQueryable<People> PeopleOrderDesc()
        {
            return db.Peoples.OrderByDescending(x => x.Age);
        }

        // PUT: api/People/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPeople(int id, People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != people.Id)
            {
                return BadRequest();
            }

            db.Entry(people).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
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

        // POST: api/People
        [ResponseType(typeof(People))]
        public IHttpActionResult PostPeople(People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Peoples.Add(people);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = people.Id }, people);
        }

        // DELETE: api/People/5
        [ResponseType(typeof(People))]
        public IHttpActionResult DeletePeople(int id)
        {
            People people = db.Peoples.Find(id);
            if (people == null)
            {
                return NotFound();
            }

            db.Peoples.Remove(people);
            db.SaveChanges();

            return Ok(people);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeopleExists(int id)
        {
            return db.Peoples.Count(e => e.Id == id) > 0;
        }
    }
}