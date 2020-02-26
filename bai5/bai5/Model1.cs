namespace bai5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THANHTOAN> THANHTOANs { get; set; }
        public virtual DbSet<THUEPHONG> THUEPHONGs { get; set; }
        public virtual DbSet<TRANGTHIETBI> TRANGTHIETBIs { get; set; }
        public virtual DbSet<SDDichVu> SDDichVus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.SDDichVus)
                .WithRequired(e => e.DICHVU)
                .HasForeignKey(e => e.ID_MaDV);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.THUEPHONGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.ID_MaKH)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.THANHTOANs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_MaNV);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.THUEPHONGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_MaNV)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.SDDichVus)
                .WithRequired(e => e.PHONG)
                .HasForeignKey(e => e.ID_MaPhong);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THUEPHONGs)
                .WithOptional(e => e.PHONG)
                .HasForeignKey(e => e.ID_MaPhong)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.TRANGTHIETBIs)
                .WithOptional(e => e.PHONG)
                .HasForeignKey(e => e.ID_MaPhong)
                .WillCascadeOnDelete();

            modelBuilder.Entity<THUEPHONG>()
                .HasMany(e => e.THANHTOANs)
                .WithOptional(e => e.THUEPHONG)
                .HasForeignKey(e => e.ID_MaHDThuePhong)
                .WillCascadeOnDelete();

            modelBuilder.Entity<THUEPHONG>()
                .HasMany(e => e.SDDichVus)
                .WithRequired(e => e.THUEPHONG)
                .HasForeignKey(e => e.ID_MaHDThuePhong)
                .WillCascadeOnDelete(false);
        }
    }
}
