using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Askona_CheckPoint
{
    [Table("InOut")]
    public partial class InOut
    {
        [Key]
        [Column(Order = 0)]
        public DateTime FFACTDATEBEGIN { get; set; }
        public DateTime? FWHDATEBEGIN { get; set; }
        public DateTime? FWHDATEEND { get; set; }
        public DateTime? FFACTDATEEND { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FID { get; set; }
        public virtual Request Request { get; set; }
    }
}
