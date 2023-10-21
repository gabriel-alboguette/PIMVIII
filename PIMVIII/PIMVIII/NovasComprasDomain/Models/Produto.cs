using PIMVIII.NovasComprasDomain.Domain;

namespace PIMVIII.NovasComprasDomain.Model
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
