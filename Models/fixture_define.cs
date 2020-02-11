namespace JABIL2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jabil.fixture_define")]
    public partial class fixture_define
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string Family { get; set; }

        [StringLength(75)]
        public string Model { get; set; }

        public int? PartNo { get; set; }

        public int? UPL { get; set; }

        [StringLength(50)]
        public string UsedFor { get; set; }

        public int? PMPeriod { get; set; }

        [StringLength(25)]
        public string Owner { get; set; }

        [StringLength(25)]
        public string RecBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EditOn { get; set; }

        [StringLength(25)]
        public string EditBy { get; set; }

        [StringLength(25)]
        public string Workcell { get; set; }
    }
}
