using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Comum.Dto
{
    public class ObjetoDeValidacao
    {
        public ObjetoDeValidacao()
        {
            Criticas = new List<string>();
        }

        public List<string> Criticas { get; set; }
        public bool Sucesso => Criticas.Count <= 0;
    }
}
