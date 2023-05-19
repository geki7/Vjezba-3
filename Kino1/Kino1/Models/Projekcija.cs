using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1.Models
{
    public class Projekcija
    {
        public DateTime DatumProjekcije { get; set; }
        public Dvorana DvoranaProjekcije { get; set; }
        public Film FilmProjekcija { get; set; }
        public bool Premijera { get; set; }
    }
}
