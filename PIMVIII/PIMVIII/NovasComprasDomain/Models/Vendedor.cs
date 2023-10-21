using Microsoft.AspNetCore.Identity;
using PIMVIII.NovasComprasDomain.Domain;

namespace PIMVIII.NovasComprasDomain.Model
{
    public class Vendedor : Base
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CNPJ { get; set; }
        public int Comissao { get; set; }
        public Endereco Endereco { get; set; }
    }
}
