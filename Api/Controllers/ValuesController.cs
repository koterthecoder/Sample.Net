using Application.Contracts;
using Application.Contracts.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private readonly ITodoItemManagementService _repo;

        public ValuesController(ITodoItemManagementService repo)
        {
            this._repo = repo;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //GET api/values/5
        public string Get(long id)
        {
            var item = _repo.GetByAccountId(id);
            return item.Created.ToString();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
