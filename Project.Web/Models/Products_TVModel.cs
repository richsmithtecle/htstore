using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class Products_TVModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public decimal Price { get; set; }
        public bool TopSeller { get; set; }
        public bool TopRated { get; set; }
        public int CategoryId { get; set; }
        public string ProductImage { get; set; }

    }
}