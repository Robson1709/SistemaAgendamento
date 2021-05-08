using SistemaWeb.Models.Enums;

namespace SistemaWeb.Models
{
    public class Pedido : Agendamento
    {
        public Agendamento Agendamento { get; set; }

        public StatusPedido StatusPedido { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
    }
}
