namespace ProjetoPedidos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public string Status { get; set; } = string.Empty;
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto>();
    }
}