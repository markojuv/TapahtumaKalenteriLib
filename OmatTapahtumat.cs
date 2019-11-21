using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TapahtumaLib
{
    public class OmatTapahtumat
    {
        public int KayttajaId { get; set; }
        public string KayttajaNimi { get; set; }
        public int TapahtumaId { get; set; }
        public string TapahtumaNimi { get; set; }
        public string Sijainti { get; set; }
        [DataType(DataType.Date)]
        public DateTime Päivämäärä { get; set; }
        public string Kategoria { get; set; }
        public decimal? Hinta { get; set; }
        public string Kuvaus { get; set; }
        public string Linkki { get; set; }
        public bool? Ikäraja { get; set; }
    }
}
