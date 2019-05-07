using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.Entity.Entity
{
    [Table("Kategoriler")]
    public class Kategori:EntityBase
    {
        public Kategori()
        {
            AltKategoriler = new List<AltKategori>();
        }
        public string KategoriAd { get; set; }
        public string Aciklama { get; set; }

        //Relation

        public virtual List<AltKategori> AltKategoriler { get; set; }

        public virtual List<Urun> Urunler { get; set; }

    }
}
