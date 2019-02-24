using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class StockContext : DbContext
    {

        public StockContext()
        {

        }
        public DbSet<StockModel> Stock { get; set; }
    }
}