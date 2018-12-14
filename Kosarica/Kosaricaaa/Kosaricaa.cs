using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica.Kosaricaaa
{
    class Kosaricaa
    {
        private Guid ID;
        private VlasnikKosarice vlasnik;
        private StatusKosarice status;
        private StavkaKosarice stavka;
        private List<StavkaKosarice> stavke = new List<StavkaKosarice>();

        public Kosaricaa(VlasnikKosarice v)
        {
            vlasnik = v;
            ID = Guid.NewGuid();
            status = StatusKosarice.Prazna;
        }
        public Guid VratiId()
        {
            return ID;
        }

        public VlasnikKosarice VratiVlasnika()
        {
            return vlasnik;
        }

        public StatusKosarice VratiStatus()
        {
            return status;
        }

        public  List<StavkaKosarice> VratiStavke()
        {

            return stavke;
        }

        public decimal VratiVrijednostUkupno()
        {
            decimal x = 0;
            foreach (StavkaKosarice s in stavke)
            {
                x += s.VratiVrijednost();
            }
            return x;
        }

        public void DodajStavku(StavkaKosarice s)
        {
            stavka = s;
            stavke.Add(s);
        }

        public void DodajStavku (string opis,int kolicina,decimal cijena)
        {
            StavkaKosarice s = new StavkaKosarice(opis, kolicina, cijena);
            stavke.Add(s);
        }

        public void DodajStavku(string opis,decimal cijena)
        {
            StavkaKosarice s = new StavkaKosarice(opis, cijena);
            stavke.Add(s);
        }

        public void BrisiStavku (int x)
        {
            stavke.RemoveAt(x);
        }

        public void BrisiStavku (StavkaKosarice s)
        {
            stavka = s;
            foreach (StavkaKosarice st in stavke)
            {
                if (s==st)
                {
                    stavke.Remove(st);
                }
            }

        }

        public void Isprazni()
        {
            foreach (StavkaKosarice s in stavke)
            {
                stavke.Remove(s);
            }
            
        }

        public void Plati()
        {
            status = StatusKosarice.Placena;
        }

        public void Storniraj()
        {
            status = StatusKosarice.Stornirana;
        }

        private bool Zakljucana ()
        {
            return status == StatusKosarice.Placena || status == StatusKosarice.Stornirana;
        }


             


    }
}
