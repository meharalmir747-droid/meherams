namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Product_ID { get; set; }

        [StringLength(10)]
        public string Product_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Product_salePrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Product_purchasePrice { get; set; }

        [StringLength(10)]
        public string Product_Pic { get; set; }

        public int? Cat_ForeignID { get; set; }
    }
}
