using System;

namespace Hotel.Comum.Modelos
{
    public class CheckOut: Entidade
    {
        public DateTime DataCheckOut { get; set; }
        public Ocupacao Ocupacao { get; set; }
        public double QtdeNoites => DataCheckOut.Subtract(Ocupacao.DataCheckIn).Days;
        public TipoPagto TipoPagto { get; set; }
    }
}
