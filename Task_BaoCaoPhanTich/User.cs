namespace Task_BaoCaoPhanTich
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string TenDL { get; set; }

        [Column(TypeName = "text")]
        public string img1 { get; set; }

        [StringLength(500)]
        public string KetLuan { get; set; }

        [Column(TypeName = "text")]
        public string img2 { get; set; }
    }
}
