using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino2
{
    public class Projekcija
    {
        public DateTime DatumProjekcije { get; set; }
        public Dvorana DvoranaProjekcije { get; set; }
        public IPredstava OdabranaPredstava { get; set; }
    }
}
