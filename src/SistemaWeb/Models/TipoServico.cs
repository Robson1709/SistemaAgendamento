using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        public List<Agendamento> Agendamentos { get; set; }

    }
}
