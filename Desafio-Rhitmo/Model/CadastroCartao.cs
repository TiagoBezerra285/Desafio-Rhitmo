using Desafio_Rhitmo.Model.Base;
using Desafio_Rhitmo.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_Rhitmo.Model
{
    [Table("cadastro_cartao")]
    public class CadastroCartao 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Column("email")]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column("cpf")]
        [Required]
        [StringLength(20)]
        public string Cpf { get; set; }


        [Column("endereco")]
        [Required]
        [StringLength(150)]
        public string Endereco { get; set; }

        [Column("cep")]
        [Required]
        [StringLength(15)]
        public string Cep { get; set; }

        [Column("estado")]
        [Required]
        [StringLength(15)]
        public string Estado { get; set; }

        [Column("cidade")]
        [Required]
        [StringLength(15)]
        public string Cidade { get; set; }


        [Column("tipo_cartao")]
        [Required]
        public TipoCartao TipoCartao { get; set; }

        [Column("nome_cartao")]
        [Required]
        [StringLength(80)]
        public string NomeCartão { get; set; }

        [Column("numero_cartao")]
        [Required]
        [StringLength(30)]
        public long NumeroCartao { get; set; }

        [Column("codigo_seguranca")]
        [Required]
        [StringLength(4)]
        public string CodigoSeguranca { get; set; }

        [Column("data_expiracao")]
        [Required]
        [StringLength(50)]
        public string DataExpiracao { get; set; }

    }
}
