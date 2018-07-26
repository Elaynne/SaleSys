namespace SalesSys.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductSales = new HashSet<ProductSale>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }

        [Column(TypeName = "money")]
        [Range(0, 999999)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [NotMapped]
        public string PriceString
        {
            get
            {
                return Price.ToString();
            }
            set
            {
                Price = decimal.Parse(value, System.Globalization.NumberStyles.Currency);
            }
        }

        [MaxLengthAttribute]
        public string Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
