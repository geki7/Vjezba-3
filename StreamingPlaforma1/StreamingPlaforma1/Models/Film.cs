using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingPlaforma1.Models
{
    public class Film : VideoSadrzaj
    {
        public int Trajanje { get; set; }

        public Film(string naziv, string opis, int trajanje) :base(naziv, opis)
        {
            Naziv = naziv;
            Opis = opis;
            Trajanje = trajanje;
        }

        public override string VratiInfo()
        {
            return this.Naziv + this.Opis + this.Trajanje;
        }
    }
}
