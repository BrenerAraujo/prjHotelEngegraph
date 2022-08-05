using Hotel.Comum.Enumerados;

namespace Hotel.Comum.Modelos
{
    public class Uh: Entidade
    {
        public string Numero { get; set; }
        public string Bloco { get; set; }
        public string Nivel { get; set; }
        public TipoUh TipoUh { get; set; }
        public EnSituacaoUh Situacao { get; set; }
    }
}
