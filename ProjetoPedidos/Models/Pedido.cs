using System.Collections.Generic;

namespace ProjetoPedidos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Status { get; set; }
        public ICollection<PedidoProduto> PedidoProdutos { get; set; }
    }
}