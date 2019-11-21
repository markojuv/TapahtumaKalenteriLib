using System;
using System.Collections.Generic;

namespace TapahtumaLib.Models
{
    public partial class Kayttajat
    {
        public int KayttajaId { get; set; }
        public string Nimi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
