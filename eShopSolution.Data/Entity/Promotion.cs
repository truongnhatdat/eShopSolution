using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyOrAll { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? DiscountAmout { get; set; }
        public string ProductId { get; set; }
        public string ProductCategoryId { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }

    }
}
