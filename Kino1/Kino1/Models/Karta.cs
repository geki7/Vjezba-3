using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1.Models
{
    public class Karta
    {
        public Projekcija OdabranaProjekcija { get; set; }
        public Sjedalo OdabranoSjedalo { get; set; }

        public Karta(Projekcija projekcija, Sjedalo sjedalo)
        {
            this.OdabranaProjekcija = projekcija;
            this.OdabranoSjedalo = sjedalo;
        }

        public double OdrediCijenu()
        {
            if(this.OdabranaProjekcija.Premijera == true)
            {
                return 80;
            }
            return 60;
        }
    }
}
