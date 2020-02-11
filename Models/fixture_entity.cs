namespace JABIL2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jabil.fixture_entity")]
    public partial class fixture_entity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fixture_entity()
        {
            inandoutrecords = new HashSet<inandoutrecords>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string BillNo { get; set; }

        public DateTime? RegDate { get; set; }

        public int? UsedCount { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(75)]
        public string Model { get; set; }

        public int? PartNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inandoutrecords> inandoutrecords { get; set; }
    }
}
