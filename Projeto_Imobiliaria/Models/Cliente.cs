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
        [RegularExpression(@"^[0-9\w]{1,3}\.[0-9\w]{1,3}\.[0-9\w]{1,3}\-[0-9\w]{1,2}$", 
         ErrorMessage = "Digite um CPF válido")]
        public string CPF { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        [RegularExpression(@"^[0-9\w]{2}\-9[0-9\w]{1,5}\-[0-9\w]{1,4}$",
         ErrorMessage = "Digite um telefone válido")]
        public string Telefone { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$",
         ErrorMessage = "Digite um E-mail válido")]
        public string Email { get; set; }


        [Column("EstadoCivil")]
        [Display(Name = "Estado Civil")]
        public string Estado_Civil { get; set; }

        [Column("Ocupacao")]
        [Display(Name = "Ocupação")]
        public string Ocupacao { get; set; }

    }
}
