namespace bai5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANHTOAN")]
    public partial class THANHTOAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThanhToan { get; set; }

        public int? ID_MaHDThuePhong { get; set; }

        public int? ID_MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }

        public int? TienPhong { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THUEPHONG THUEPHONG { get; set; }
    }
}
