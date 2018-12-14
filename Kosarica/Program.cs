using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kosarica.Kosaricaaa;



namespace Kosarica
{
    class Program
    {
        static void Main(string[] args)
        {
            VlasnikKosarice iva = new VlasnikKosarice("iva.ivic@mev.hr", "Iva Ivic", "O.Z.37");
            Kosaricaa k = new Kosaricaa(iva);
            k.DodajStavku("Mobitel ", 2, (decimal)1356.52);
            k.DodajStavku("Baterije AAA", 8, (decimal)21.92);
            k.DodajStavku("USB Kabel", (decimal)15.85);
            Console.WriteLine("{0}",iva.ToString());
            k.Plati();
            Ispis(k);

        }
        public static void Ispis(Kosaricaa k)
        {
            
            Console.WriteLine("Kosarica ID: {0}", k.VratiId());
            Console.WriteLine("Kupac:{0}", k.VratiVlasnika());
            Console.WriteLine("----------------------------------------------------------------------------------------------");


            int x = 1;
            foreach (StavkaKosarice s in k.VratiStavke())
            {
                Console.WriteLine("{0}. {1}", x, s.ToString());
                x++;
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ukupno za platiti: {0}", k.VratiVrijednostUkupno());
            Console.WriteLine("Status:{0}\n\n", k.VratiStatus().ToString());

        }

    }

  
}
