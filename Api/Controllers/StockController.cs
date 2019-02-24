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


        StockContext _context = new StockContext();

        private static List<StockModel> listaEstoque = new List<StockModel>();
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
        public StockModel Get(string id)
        {
            var memberdetail = (from a in _context.Stock where a.Id == id select a).FirstOrDefault();

            return memberdetail;
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]StockModel value)
        {
            // _context.Stock.InsertOnSubmit(value);

            //Save the submitted record  
            // _context.SubmitChanges();

            //return response status as successfully created with member entity  
            var msg = Request.CreateResponse(HttpStatusCode.Created, value);

            //Response message with requesturi for check purpose  
            msg.Headers.Location = new Uri(Request.RequestUri + value.Id.ToString());

            return msg;
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put(int id, [FromBody]StockModel value)
        {
            //fetching and filter specific member id record   
            var memberdetail = (from a in _context.Stock where a.Id == id.ToString() select a).FirstOrDefault();

            //checking fetched or not with the help of NULL or NOT.  
            if (memberdetail != null)
            {
                //set received _member object properties with memberdetail  
                memberdetail.DateOpened = value.DateOpened;

                //save set allocation.  
                //_context.SubmitChanges();

                //return response status as successfully updated with member entity  
                return Request.CreateResponse(HttpStatusCode.OK, memberdetail);
            }
            else
            {
                //return response error as NOT FOUND  with message.  
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Member Not Found");
            }

        }
        public HttpResponseMessage Patch(int id, [FromBody] StockModel value)
        {
            var memberdetail = (from a in _context.Stock where a.Id == id.ToString() select a).FirstOrDefault();

            //checking fetched or not with the help of NULL or NOT.  
            if (memberdetail != null)
            {
                //set received _member object properties with memberdetail  
                memberdetail.DateOpened = value.DateOpened;

                //save set allocation.  
                //_context.SubmitChanges();

                //return response status as successfully updated with member entity  
                return Request.CreateResponse(HttpStatusCode.OK, memberdetail);
            }
            else
            {
                //return response error as NOT FOUND  with message.  
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Member Not Found");
            }
        }
        // DELETE api/<controller>/5
        public string Delete(string id)
        {

            StockModel estoque = listaEstoque.Where(n => n.Id == id)
                                               .Select(n => n)
                                               .First();

            listaEstoque.Remove(estoque);

            return "Registro excluido com sucesso!";
        }
    }
}