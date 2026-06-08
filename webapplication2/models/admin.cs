namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int Admin_ID { get; set; }

        [StringLength(10)]
        public string Admin_Name { get; set; }

        [StringLength(10)]
        public string Admin_Email { get; set; }
       
        public int? Admin_password { get; set; }
        [NotMapped]
        public int? Admin_newpassword { get; set; }

        [StringLength(10)]
        public string Admin_address { get; set; }

        public int? Admin_cell { get; set; }
    }
}
