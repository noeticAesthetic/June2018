using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace June2018.Models
{
    public class Product
    {
        public int ID { get; set; }

        [StringLength(24, MinimumLength = 3)]
        public string Sku { get; set; }

        [StringLength(75, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Category { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Date Added"), DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }
    }
}
//[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
//[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)] 