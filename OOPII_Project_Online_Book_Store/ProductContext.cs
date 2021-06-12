using StockExchange;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True")
        { }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Bonds> Bonds { get; set; }
        public DbSet<Possessions> Possessions { get; set; }

    }
}
