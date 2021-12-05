using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaBack.Data
{
    public class PizzaContext: DbContext
    {
        public PizzaContext()
               : base("DbConnection")
        { }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}