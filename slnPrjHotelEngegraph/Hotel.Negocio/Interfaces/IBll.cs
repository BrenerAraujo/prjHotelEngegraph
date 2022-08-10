using Hotel.Comum.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio.Interfaces
{
    public interface IBll<T>
    {
        ObjetoDeValidacao Validar(T objeto);
    }
}
