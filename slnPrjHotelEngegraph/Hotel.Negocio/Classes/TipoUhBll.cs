using Hotel.Comum.Dto;
using Hotel.Comum.Modelos;
using Hotel.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio.Classes
{
    public class TipoUhBll : IBll<TipoUh>
    {
        public ObjetoDeValidacao Validar(TipoUh objeto)
        {
            var result = new ObjetoDeValidacao();
            if (string.IsNullOrWhiteSpace(objeto.Descricao))
            {
                result.Criticas.Add("Descrição deve ser informada.");
            }

            if(objeto.QtdeAdt <= 0)
            {
                result.Criticas.Add("Deve haver ao menos um adulto para completar cadastro.");
            }

            if(objeto.QtdeChd < 0)
            {
                result.Criticas.Add("Quantidade de crianças não pode ser negativa.");
            }

            if(objeto.ValorDiaria <= 0)
            {
                result.Criticas.Add("Valor da diária deve ser informado e não pode ser negativo");
            }

            if(objeto.ValorAdicional < 0)
            {
                result.Criticas.Add("Valor adicional não pode ser um valor negativo");
            }


            return result;
        }
    }
}
