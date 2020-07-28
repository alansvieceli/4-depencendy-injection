using System;

namespace teste01_constructor
{
    public class Empresa
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        //public Endereco Endereco { get; set; } //auto grau de acoplamento
        public IEndereco Endereco { get; set; } //acoplamento minimizado

        public Empresa(IEndereco endereco)
        {
            this.Endereco = endereco;
        }
    }
}