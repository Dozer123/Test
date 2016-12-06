using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleREST.Models;

namespace SimpleREST.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "Person1", "Person2" };
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            Person person = new Person();

            person.ID = id;
            person.FirstName = "Sergey";
            person.LastName = "Biryukov";
            person.PayRate = 45.44;
            person.StartDate = DateTime.Parse("5/9/2014");
            person.EndDate = DateTime.Parse("5/9/2016");

            return person;
        }

        // POST: api/Person
        public void Post([FromBody]Person value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
