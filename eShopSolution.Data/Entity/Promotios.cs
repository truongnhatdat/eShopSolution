using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Promotios
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyOrAll { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmout { get; set; }
        public int? ProductId { get; set; }
        public int? ProductCategoryId { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }

    }
}
