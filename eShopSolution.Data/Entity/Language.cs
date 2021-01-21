using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public List<ProductTransaction> ProductTransactions { get; set; }
        public List<CatogriesTransacsion> CatogriesTransacsions { get; set; }
    }
}
