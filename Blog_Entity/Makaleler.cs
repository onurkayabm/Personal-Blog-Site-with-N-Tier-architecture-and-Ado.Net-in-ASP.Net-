using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Entity
{
   public class Makaleler
    {
        public int MakaleID { get; set; }
        public string Baslik { get; set; }

        public string Icerik { get; set; }
        public int KategoriID { get; set; }
        public DateTime KayitTarihi { get; set; }
        public Guid YazarID { get; set; }
        public int OkunmaSayisi { get; set; }

        public Int64 ToplamPuan { get; set; }
        public int OyVerenKisiSayisi { get; set; }
    }
}
