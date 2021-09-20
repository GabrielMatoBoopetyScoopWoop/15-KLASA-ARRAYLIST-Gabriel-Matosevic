using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaArraylistGabrielMatosevic
{
    class Automobil
    {
        private string Marka { get; set; }
        public string DajMarku()
        {
            return Marka;
        }
        public Automobil(string m)
        {
            Marka = m;
        }
    }
}
