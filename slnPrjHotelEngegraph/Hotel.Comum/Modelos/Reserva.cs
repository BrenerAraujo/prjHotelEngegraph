using Hotel.Comum.Enumerados;
using System;

namespace Hotel.Comum.Modelos
{
    public class Reserva: Entidade
    {
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int QtdeAdt { get; set; }
        /// <summary>
        /// Quantidade crianças
        /// </summary>
        public int QtdeChd { get; set; }
        public TipoUh TipoUh { get; set; }
        public string Observacoes { get; set; }
        public EnSituacaoReserva Situacao { get; set; }
    }
}
