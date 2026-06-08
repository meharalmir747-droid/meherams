namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        // Constructor: Jab bhi Category ka object bane, Products ki list initialize ho jaye
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int cat_ID { get; set; }

        [StringLength(10)]
        public string cat_name { get; set; }

        // YE LINE MISSING THI: Category aur Product ka relationship banane ke liye
        public virtual ICollection<Product> Products { get; set; }
    }
}