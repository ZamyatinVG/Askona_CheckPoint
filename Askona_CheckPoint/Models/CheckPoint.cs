using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Askona_CheckPoint
{
    public partial class CheckPoint : DbContext
    {
        public CheckPoint() : base("name=CheckPoint") { }

        public virtual DbSet<InOut> InOut { get; set; }
        public virtual DbSet<Request> Request { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>()
                .HasMany(e => e.InOut)
                .WithRequired(e => e.Request)
                .WillCascadeOnDelete(false);
        }
    }
    public class Request_View
    {
        public int FID { get; set; }
        [StringLength(50)]
        public string FDESCR { get; set; }
        public DateTime FCREATEDATE { get; set; }
        [StringLength(255)]
        public string FGUESTFIO { get; set; }
        [StringLength(255)]
        public string FGUESTJOB { get; set; }
        [StringLength(128)]
        public string FAUTOMARK { get; set; }
        [StringLength(128)]
        public string FAUTONUMBER { get; set; }
        [StringLength(128)]
        public string FLOCATION { get; set; }
        public DateTime FDATEBEGIN { get; set; }
        public DateTime FDATEEND { get; set; }
        [StringLength(128)]
        public string FMEETFIO { get; set; }
        [StringLength(128)]
        public string FSTATUS { get; set; }
        [StringLength(255)]
        public string FPURPOSE { get; set; }
        public DateTime? FUTVDATE { get; set; }
        [StringLength(128)]
        public string FPHONE { get; set; }
    }
    public class Check_View
    {
        public int FID { get; set; }
        [StringLength(255)]
        public string FGUESTFIO { get; set; }
        [StringLength(128)]
        public string FAUTOMARK { get; set; }
        [StringLength(128)]
        public string FAUTONUMBER { get; set; }
        [StringLength(128)]
        public string FLOCATION { get; set; }
        public DateTime FDATEBEGIN { get; set; }
        public DateTime FDATEEND { get; set; }
        [StringLength(128)]
        public string FSTATUS { get; set; }
        public DateTime? FFACTDATEBEGIN { get; set; }
        public DateTime? FFACTDATEEND { get; set; }
        [StringLength(128)]
        public string FMEETFIO { get; set; }
        [StringLength(255)]
        public string FGUESTJOB { get; set; }
        public DateTime? FWHDATEBEGIN { get; set; }
        public DateTime? FWHDATEEND { get; set; }
        [StringLength(128)]
        public string FWHCOMMENT { get; set; }
        [StringLength(50)]
        public string FDESCR { get; set; }
        [StringLength(255)]
        public string FPURPOSE { get; set; }
        public DateTime? FUTVDATE { get; set; }
        [StringLength(128)]
        public string FPHONE { get; set; }
        [StringLength(128)]
        public string FWHPERSON { get; set; }
    }
    public class Warehouse_View
    {
        public int FID { get; set; }
        [StringLength(255)]
        public string FGUESTFIO { get; set; }
        [StringLength(128)]
        public string FAUTOMARK { get; set; }
        [StringLength(128)]
        public string FAUTONUMBER { get; set; }
        [StringLength(128)]
        public string FLOCATION { get; set; }
        public DateTime FDATEBEGIN { get; set; }
        public DateTime FDATEEND { get; set; }
        [StringLength(128)]
        public string FSTATUS { get; set; }
        public DateTime? FWHDATEBEGIN { get; set; }
        public DateTime? FWHDATEEND { get; set; }
        [StringLength(128)]
        public string FMEETFIO { get; set; }
        [StringLength(255)]
        public string FGUESTJOB { get; set; }
        [StringLength(128)]
        public string FWHCOMMENT { get; set; }
        [StringLength(50)]
        public string FDESCR { get; set; }
        [StringLength(255)]
        public string FPURPOSE { get; set; }
        public DateTime? FUTVDATE { get; set; }
        [StringLength(128)]
        public string FPHONE { get; set; }
        [StringLength(128)]
        public string FWHPERSON { get; set; }
    }
}
