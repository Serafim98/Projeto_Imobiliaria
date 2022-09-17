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

        [Column("ValorMensal")]
        [Display(Name = "Valor Mensal")]
        public float Valor_Mensal { get; set; }

        [Column("ValorCaucao")]
        [Display(Name = "Valor Caução")]
        public float Valor_Caucao { get; set; }
    }
}
