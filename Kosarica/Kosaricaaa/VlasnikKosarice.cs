using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica.Kosaricaaa
{
    class VlasnikKosarice
    {
        private string id;
        private string naziv;
        private string adresa;
        
        public VlasnikKosarice(string id,string naziv,string adresa)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
        }

        public string VratiID()
        {
            return id;
        }

        public string VratiNaziv()
        {
            return naziv;
        }

        public string VratiAdresu()
        {
            return adresa;
        }

        public void PromieniNaziv(string naziv)
        {
            this.naziv = naziv;
        }

        public void PromijeniAdresu(string adresa)
        {
            this.adresa = adresa;
        }

        public override string ToString()
        {
            return string.Format("Naziv kupca: {0}\nId kupca:{1}\nAdresa:{2}",VratiNaziv(),VratiID(),VratiAdresu());
        }
    }
}
