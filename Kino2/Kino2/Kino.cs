using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    public class Kino
    {
        public List<Dvorana> PopisDvorana { get; set; }
        public List<Projekcija> PopisProjekcija { get; set; }

        public List<Projekcija> DohvatiProjekcije(string naziv)
        {
            return Projekcija.FindAll()
        }
    }
}
