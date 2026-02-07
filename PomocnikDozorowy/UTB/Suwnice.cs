using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikDozorowy.UTB
{
    internal class Suwnice
    {
        //Dane Identyfikacyjne suwnicy
        public string? ID { get; set; }
        public int NrFabryczny { get; set; }
        public int RokProdukcji { get; set; }
        //public string? UdzwigNominalny { get; set; } -- przeniesiono do Danych techniczych!
        public string? Producent {  get; set; }
        public int RokMontazu { get; set; }
        public string? Lokalizacja { get; set; }
        public string? Wlasciciel {  get; set; }
        public string? Typ_Model { get; set; }

        //Dane Techniczne suwnicy
        public string? RodzajSuwnicy { get; set; } // Pomostowa / Bramowa / Półbramowa
        public string? UdzwigNominalny { get; set; } // kg/t
        public int Rozpietosc { get; set; } // Podawane w metrach
        public int WysokoscPodnoszenia { get; set; } //Podawane w metrach
        public int LiczbaBiegow { get; set; }
        public string? KlasaPracy {get; set; } // np: FEM / ISO
        public string? Zasilanie { get; set; } // np 3x400V, szynoprzewód
        public string? TypSterowania {  get; set; } // kaseta / radio / kabina
        public string? GrupaNatezeniaPracy { get; set; } // A1, A7, G3 itp





        //Dane Urzędu Dozoru Technicznego
        //public string


    }
}
