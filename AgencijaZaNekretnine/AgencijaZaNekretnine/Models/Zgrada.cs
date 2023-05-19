using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Models
{
    public class Zgrada
    {
        public string OzanakaZgrade { get; set; }
        public List<Kat> Katovi = new List<Kat>();
    }
}
