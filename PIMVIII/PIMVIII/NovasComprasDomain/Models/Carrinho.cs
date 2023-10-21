using PIMVIII.NovasComprasDomain.Domain;

namespace PIMVIII.NovasComprasDomain.Model
{
    public class Carrinho : Base
    {
        public DateTime DataPedido { get; set; }
        public float ValorTotal { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
    }
}
