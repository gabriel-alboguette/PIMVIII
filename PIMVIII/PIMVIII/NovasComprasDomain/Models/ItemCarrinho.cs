namespace PIMVIII.NovasComprasDomain.Model
{
    public class ItemCarrinho
    {
        public int Quantidade { get; set; }
        public float Total { get; set; }
        public Carrinho Carrinho { get; set; }
        public Produto Produto { get; set; }
    }
}
