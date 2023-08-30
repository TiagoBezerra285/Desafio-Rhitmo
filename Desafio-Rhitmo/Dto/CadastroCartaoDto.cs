using Desafio_Rhitmo.Utils;
using System;

namespace Desafio_Rhitmo.Dto
{
    public class CadastroCartaoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public string Endereco { get; set; }
        public string Cep { get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public TipoCartao TipoCartao { get; set; }
        public string NomeCartão { get; set; }
        public string NumeroCartao { get; set; }
        public string CodigoSeguranca { get; set; }
        public string DataExpiracao { get; set; }
        //public DateTime DataCriacao { get; set; }
    }
}
