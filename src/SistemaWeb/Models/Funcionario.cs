using System;
using System.Collections.Generic;

namespace SistemaWeb.Models
{
    public class Funcionario 
    {
        public int Id { get; set; }

        public int DepartamentoId { get; set; }

        //[Required(ErrorMessage = "{0} Obrigatório")]
        //[StringLength(60, MinimumLength = 3, ErrorMessage = " Tamanho do campo {0} deve ser entre {2} e {1}")]
        //[Display(Name = "Nome")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "{0} Obrigatório")]
        //[Display(Name = "E-mail")]
        //[EmailAddress(ErrorMessage = "Informe um {0} válido")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "{0} Obrigatório")]
        //[StringLength(11, MinimumLength = 10, ErrorMessage = " Tamanho do campo {0} deve ser entre {2} e {1}")]
        //[Display(Name = "Telefone")]
        public string Telefone { get; set; }

        //[Required(ErrorMessage = "{0} Obrigatório")]
        //[Display(Name = "Data de Nascimento")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        //[Required(ErrorMessage = "{0} Obrigatório")]
        //[Display(Name = "Salário")]
        //[Range(100.0, 50000.0, ErrorMessage = "{0} mínimo {1} máximo {2}")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Salario { get; set; }

        /* EF Relation */

        public Departamento Departamento { get; set; }
        
        public List<Agendamento> Agendamentos { get; set; }
        
    }
}