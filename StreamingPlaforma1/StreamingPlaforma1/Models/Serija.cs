using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlaforma1.Models
{
    public class Serija : VideoSadrzaj
    {
        public List<Sezona> Sezone = new List<Sezona>();

        public Serija(string naziv, string opis) : base(naziv, opis)
        {

        }

        public override string VratiInfo()
        {
            return this.Naziv + this.Opis;
        }
    }
}
