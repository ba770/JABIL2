namespace JABIL2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jabil.user")]
    public partial class user
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Department { get; set; }

        [StringLength(100)]
        public string Privilege { get; set; }

        [StringLength(11)]
        public string Tel { get; set; }
    }
}
