using System;
using System.Collections.Generic;

namespace TapahtumaLib.Models
{
    public partial class Tapahtumat
    {
        public int TapahtumaId { get; set; }
        public string Nimi { get; set; }
        public string Sijainti { get; set; }
        public DateTime Päivämäärä { get; set; }
        public string Kategoria { get; set; }
        public decimal? Hinta { get; set; }
        public string Kuvaus { get; set; }
        public string Linkki { get; set; }
        public bool? Ikäraja { get; set; }
        public byte[] Kuva { get; set; }
    }
}
