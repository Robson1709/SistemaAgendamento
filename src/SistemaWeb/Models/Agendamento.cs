using SistemaWeb.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        
        public StatusAgenda Status { get; set; }
        
        [Display(Name = "Tipo Serviço")]
        public TipoServico TipoServico { get; set; }

        [Display(Name = "Funcionario")]
        public int FuncionarioId { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Tipo Serviço")]
        public int TipoServicoId { get; set; }

        /* EF Relation */

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }


    }
}
