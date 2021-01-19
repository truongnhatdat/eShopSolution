﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class ProductTransaction
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public int? LanguageId { get; set; }

    }
}
