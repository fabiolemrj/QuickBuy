namespace QuickBuy.Dominio.Contratos
{
    public class ItemPedido:Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {


        }
    }
}
