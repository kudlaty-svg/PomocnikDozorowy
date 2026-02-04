using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikDozorowy.UTB
{
    internal class Suwnice
    {
        //Dane Techniczne suwnicy
        public string? ID { get; set; }
        public int NrFabryczny { get; set; }
        public int RokProdukcji { get; set; }
        public string? UdzwigNominalny { get; set; }
        public string? Producent {  get; set; }

    }
}
