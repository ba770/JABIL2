namespace JABIL2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("jabil.inandoutrecords")]
    public partial class inandoutrecords
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime? MoveDate { get; set; }

        [StringLength(25)]
        public string TakenBy { get; set; }

        public bool IsOut { get; set; }

        [StringLength(25)]
        public string ProductLine { get; set; }

        public int Num { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public virtual fixture_entity fixture_entity { get; set; }
    }
}
