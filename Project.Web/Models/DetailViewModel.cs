using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class DetailViewModel
    {
        public string Mfr { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //Avg rating here too?
        // Top rated here too?
        // Detailed features?
    }
}