namespace AppWithDataset.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [Required]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }

        public int? CODE { get; set; }

        [Column(TypeName = "image")]
        public byte[] AVATAR { get; set; }
    }
}
