using PIMVIII.NovasComprasDomain.Domain;

namespace PIMVIII.NovasComprasDomain.Model
{
    public class Endereco : Base
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public long Cep { get; set; }
    }
}
