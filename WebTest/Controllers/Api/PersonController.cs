using BAL.Interfaces;
using Microsoft.Practices.Unity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebTest.Controllers.Api
{
    public class PersonController : ApiController
    {
        [Dependency]
      public  ICRUDFacade<Person> facade { get; set; }


        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return facade.get().ToList();
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return facade.get(id);
        }

        // POST: api/Person
        public void Post([FromBody]Person value)
        {
            facade.save(value);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person value)
        {
            value.Id = id;
            facade.save(value);
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            facade.delete(id);
        }
    }
}
