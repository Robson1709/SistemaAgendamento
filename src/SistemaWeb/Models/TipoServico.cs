using System.Collections.Generic;

namespace SistemaWeb.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }


        public List<Agendamento> Agendamentos { get; set; }

    }
}
