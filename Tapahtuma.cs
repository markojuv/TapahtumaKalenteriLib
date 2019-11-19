using System;
using System.Collections.Generic;
using System.Linq;
using TapahtumaLib.Models;

namespace TapahtumaLib
{
    public class Tapahtuma
    {
        EventDBContext db = new EventDBContext();

        public List<Tapahtumat> KaikkiTapahtumat()
        {
            return db.Tapahtumat.ToList();
        }
    }
}
