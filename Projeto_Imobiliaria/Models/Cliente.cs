using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Projeto_Imobiliaria.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        [Display(Name = "Código")]
        public int ID { get; set; }


        [Column("NomeCompleto")]
        [Display(Name = "Nome Completo")]
        public string Nome_Completo { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Column("EstadoCivil")]
        [Display(Name = "Estado Civil")]
        public string Estado_Civil { get; set; }

        [Column("Ocupacao")]
        [Display(Name = "Ocupacao")]
        public string Ocupacao { get; set; }

    }
}
