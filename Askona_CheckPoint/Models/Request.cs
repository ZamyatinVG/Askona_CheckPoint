using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Askona_CheckPoint
{
    [Table("Request")]
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            InOut = new HashSet<InOut>();
        }
        [Key]
        public int FID { get; set; }
        [Required]
        [StringLength(50)]
        public string FDESCR { get; set; }
        public DateTime FCREATEDATE { get; set; }
        [Required]
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
        [StringLength(255)]
        public string FPURPOSE { get; set; }
        public DateTime FDATEBEGIN { get; set; }
        public DateTime FDATEEND { get; set; }
        [StringLength(128)]
        public string FMEETFIO { get; set; }
        [StringLength(20)]
        public string FMEETTABNUMBER { get; set; }
        public DateTime? FFACTDATEBEGIN { get; set; }
        public DateTime? FFACTDATEEND { get; set; }
        [Required]
        [StringLength(128)]
        public string FSTATUS { get; set; }
        [StringLength(128)]
        public string FPHONE { get; set; }
        public DateTime? FUTVDATE { get; set; }
        public DateTime? FWHDATEBEGIN { get; set; }
        public DateTime? FWHDATEEND { get; set; }
        [StringLength(128)]
        public string FWHCOMMENT { get; set; }
        [StringLength(128)]
        public string FWHPERSON { get; set; }
        [StringLength(16)]
        public string FNREC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InOut> InOut { get; set; }
    }
}