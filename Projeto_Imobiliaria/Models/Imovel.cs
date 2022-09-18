using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_Imobiliaria.Models
{
    [Table("Imovel")]
    public class Imovel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Column("Logradouro")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Column("Numero")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Column("ValorAlguel")]
        [Range(10, 99999.99,
             ErrorMessage = "O Preço do aluguel deve estar entre " +
                            "10,00 e 99999,99.")]
        [Display(Name = "Valor do Aluguel")]
        public float PrecoVenda { get; set; }

        [Column("ValorCaucao")]
        [Range(10, 99999.99,
             ErrorMessage = "O Preço da caução deve estar entre " +
                            "10,00 e 99999,99.")]
        [Display(Name = "Valor da Caução")]
        public float PrecoCaucao { get; set; }
    }
}
