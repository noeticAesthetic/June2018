using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace June2018.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product> products;
        public SelectList categories;
        public string productCategory { get; set; }
    }
}