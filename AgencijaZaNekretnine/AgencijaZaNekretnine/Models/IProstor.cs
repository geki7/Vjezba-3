using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaZaNekretnine.Models
{
    public interface IProstor
    {
        string OzanakaProstora { get; set; }
        bool Slobodan { get; set; }
        int ID_kata { get; set; }
        Kat KatProstora { get; set; }

        void Prodaj(string kupac);
    }
}
