using Hotel.Comum.Enumerados;
using System;

namespace Hotel.Comum.Modelos
{
    public class Hospede: Entidade
    {
        const int IDADE_CRIANCA = 12;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Sobrenome}, {Nome}";
        public DateTime DataNascimento { get; set; }
        public EnGenero Genero { get; set; }
        public string NumeroDocumento { get; set; }
        public string Endereco { get; set; }
        public string CidadeOrigem { get; set; }
        public string Uf { get; set; }
        public bool IsEstrangeiro { get; set; }
        public bool IsChd => Math.Truncate(DateTime.Now.Subtract(DataNascimento).TotalDays / 365) <= IDADE_CRIANCA;
    }
}
