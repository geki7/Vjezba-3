using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Models
{
    public class Agencija
    {
        public string NazivAgencije { get; set; }
        public List<Zgrada> Zgrade = new List<Zgrada>();

        public void ProdajProstor(string oznakaProstora, string kupac)
        {
            foreach(var item in Zgrade)
            {
                foreach(var item2 in item.Katovi)
                {
                    var prostor = item2.Prostor.Find(x => x.OzanakaProstora == oznakaProstora && x.Slobodan == true);
                    prostor.Prodaj(kupac);
                }
            }
        }
    }
}
