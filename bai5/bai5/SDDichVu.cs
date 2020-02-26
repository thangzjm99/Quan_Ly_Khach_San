namespace bai5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDDichVu")]
    public partial class SDDichVu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MaDV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MaPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MaHDThuePhong { get; set; }

        public int? SoLuong { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual THUEPHONG THUEPHONG { get; set; }
    }
}
