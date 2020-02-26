namespace bai5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANGTHIETBI")]
    public partial class TRANGTHIETBI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTTB { get; set; }

        [StringLength(50)]
        public string TenTTB { get; set; }

        public int? ID_MaPhong { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public int? GiaTri { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
