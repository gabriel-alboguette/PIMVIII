using PIMVIII.NovasComprasDomain.Domain;
using System.Reflection.Metadata.Ecma335;

namespace PIMVIII.NovasComprasDomain.Model
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
    }
}
