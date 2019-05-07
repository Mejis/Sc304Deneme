using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.Entity.Entity
{
    [Table("Satislar")]
    public class Satis:EntityBase
    {
        public Satis()
        {
            this.Tarih = DateTime.Now;
            this.teslimTarihi = DateTime.Now;
            this.toplamMiktar = 1;
            this.toplamTutar = 0;
            SatisDetaylar = new List<SatisDetay>();
        }

        [Required]
        public DateTime Tarih { get; set; }
        public int uyeID { get; set; }
        [Required]
        public int toplamMiktar { get; set; }
        [Required]
        [Column(TypeName ="money")]
        public decimal toplamTutar { get; set; }
        [Required]
        public DateTime teslimTarihi { get; set; }
        public byte durumu { get; set; }    

        //Relations
        public virtual Uye Uye { get; set; }
        public virtual List<SatisDetay> SatisDetaylar { get; set; }

    }
}
