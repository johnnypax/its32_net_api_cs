using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez01_classi.Classi
{
    public class Persona
    {
        public String? Nominativo { get; set; }
        public String Livello { get; set; } = null!;

        private int eta;

        public int Eta
        {
            get { return eta; }
            set {
                if (value >= 0)
                    eta = value;
                else
                    Console.WriteLine("Errore età");
            }
        }

    }
}
