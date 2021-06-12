using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public abstract class Product
    {
        static int idcount = 1;

        public string Name { get; set; }

        public int Id { get; set; }

        public double Price { get; set; }

        public static int Idcount { get { return idcount; } set { idcount = value; } }

        public string Picture { get; set; }

        public string Issue { get; set; }

        public Product(string name, int id, double price, string picture, string issue)
        {
            this.Name = name;

            Idcount++;
            this.Id = Idcount;
            this.Price = price;
            this.Picture = picture;
            this.Issue = issue;
        }
        public Product()
        { }
        public abstract void printProperties();
    }
}
