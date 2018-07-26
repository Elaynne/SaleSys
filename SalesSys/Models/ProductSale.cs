namespace SalesSys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        [Key]
        public int IdProductSale { get; set; }

        public int IdProduct { get; set; }

        public int IdSale { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
