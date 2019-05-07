using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.Entity.Entity
{
    [Table("AltKategoriler")]
    public class AltKategori : EntityBase
    {
        [Required]
        [StringLength(50)]
        public string AltKategoriAd { get; set; }
        public int? kategoriID { get; set; }
        public string Aciklama { get; set; }

        //Relation
        public virtual Kategori Kategori { get; set; }

        public virtual List<Urun> Urunler { get; set; }

    }
}
