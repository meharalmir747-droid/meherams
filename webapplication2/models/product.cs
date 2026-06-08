namespace WebApplication2.Models
{
    using System;
    using System.Web;
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

        [NotMapped]
        public HttpPostedFileBase img { get; set; }

        // Aapka foreign key column
        public int? Cat_ForeignID { get; set; }

        // YE LINES ADD KI HAIN: Entity Framework ko relationship samjhane ke liye
        [ForeignKey("Cat_ForeignID")]
        public virtual Category Category { get; set; }
    }
}