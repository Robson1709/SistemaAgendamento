using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Cliente 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = " Tamanho do campo {0} deve ser entre {2} e {1}")]        
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = " Tamanho do campo {0} deve ser entre {2} e {1}")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Informe um {0} válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        public List<Agendamento> Agendamentos { get; set; }

    }
}
