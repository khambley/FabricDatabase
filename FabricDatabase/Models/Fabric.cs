using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FabricDatabase.Models
{
    public class Fabric
    {
        public int FabricId { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory1 { get; set; }
        public string SubCategory2 { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string Content { get; set; }
        public string Design { get; set; }
        public List<string> Tags { get; set; }
        public double Amount { get; set; }
        public string Source { get; set; }
        public string Notes { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchaseAmount { get; set; }

    }
}