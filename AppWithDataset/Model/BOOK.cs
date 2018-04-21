namespace AppWithDataset.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOKS")]
    public partial class BOOK
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string NAME { get; set; }

        [Column(TypeName = "ntext")]
        public string CONTENT { get; set; }

        [StringLength(100)]
        public string AUTHOR { get; set; }

        [StringLength(100)]
        public string PUBLISHER { get; set; }

        public int? COST { get; set; }

        public short? IN_LIB { get; set; }

        public short? OUT_LIB { get; set; }

        [Column(TypeName = "image")]
        public byte[] COVER { get; set; }
    }
}
