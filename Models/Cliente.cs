using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApp.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O campo {0} deve conter uma data válida")]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [MaxLength(11)]
        [RegularExpression(@"[0-9]{11}$", ErrorMessage = "O campo {0} deve ser preenchido com 11 dígitos.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
