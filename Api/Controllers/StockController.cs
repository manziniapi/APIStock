using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class StockController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<StockModel> Get()
        {
            var list = new List<StockModel>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new StockModel
                {
                    Id = i.ToString(),
                    Type = "Rice",
                    ExpirationDate = "1" + i.ToString() + "-02-2019",
                    ExpirationOpened = "3"
                });


            }

            return list;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]StockModel value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }
        public void Patch(int id, [FromBody] StockModel value)
        {

        }
        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}