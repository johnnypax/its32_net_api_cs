using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez02_classi_avanzate.Classi
{
    internal class Persona
    {
        public String? Nome { get; set; }
        public String? Cognome { get; set; }
        public int? Eta { get; set; }

        public int a { get; set; }
        public int? b { get; set; }

        public override string ToString()
        {
            return $"Nom: {Nome}, Cog: {Cognome}, Età: {Eta}";
        }
    }
}
