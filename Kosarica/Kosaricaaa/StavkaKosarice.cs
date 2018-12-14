using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica.Kosaricaaa
{
    class StavkaKosarice
    {
        private string opis;
        private int kolicina;
        private decimal cijena;

        public StavkaKosarice(string opis,int kolicina,decimal cijena)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }

        public StavkaKosarice(string opis,decimal cijena)
        {
            this.opis = opis;
            kolicina = 1;
            this.cijena = cijena;
        }

        public string VratiOpis()
        {
            return opis;
        }

        public int VratiKolicinu()
        {
            return kolicina;
        }

        public decimal VratiCijenu()
        {
            return cijena;
        }

        public decimal VratiVrijednost()
        {
            return (decimal)cijena * kolicina;
        }

        public override string ToString()
        {
           
            return string.Format("Opis artikla:{0,5} Kolicina:{1,10} Cijena:{2,10:F2} Iznos:{3,10:F2}",VratiOpis(),VratiKolicinu(),VratiCijenu(),VratiVrijednost());
            
        }

    }
}
