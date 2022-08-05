using Hotel.Comum.Enumerados;
using System;

namespace Hotel.Comum.Modelos
{
    public class Ocupacao: Entidade
    {
        public DateTime DataCheckIn { get; set; }
        public EnSituacaoOcupacao Situacao { get; set; }
        public Reserva Reserva { get; set; }
    }
}
