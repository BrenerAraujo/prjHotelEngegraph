namespace Hotel.Comum.Modelos
{
    public class HospedeOcupacao: Entidade
    {
        public Hospede Hospede { get; set; }
        public Ocupacao Ocupacao { get; set; }
    }
}
