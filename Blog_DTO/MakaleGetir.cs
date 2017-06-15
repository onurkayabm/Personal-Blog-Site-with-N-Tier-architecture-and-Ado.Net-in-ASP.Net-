using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_DTO
{
   public class MakaleGetir
    {
        public int MakaleID { get; set; }
        public string Icerik { get; set; }
        public string Baslik { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Gonderen { get; set; }
        public int OkunmaSayisi { get; set; }

    }
}
