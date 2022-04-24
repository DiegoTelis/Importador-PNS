using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDbPNS
{
    public class Coluna
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public string Tamanho { get; set; }

        public Coluna()
        {

        }
    }

    public class Nov
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
    }
}
