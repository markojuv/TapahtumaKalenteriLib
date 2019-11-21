using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TapahtumaLib.Models;

namespace TapahtumaLib
{
    public class Kayttaja
    {
        EventDBContext db = new EventDBContext();

        public List<Kayttajat> KaikkiKayttajat()
        {
            return db.Kayttajat.ToList();

        }
    }
}
