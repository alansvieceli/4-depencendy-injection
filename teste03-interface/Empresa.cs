using System;

namespace teste03_interface
{
    public class Empresa : IEnderecoIJ
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        //public Endereco Endereco { get; set; } //auto grau de acoplamento
        public IEndereco Endreco { get; private set; } //acoplamento minimizado

        public void setEndereco(IEndereco endereco)
        {
            this.Endreco = endereco;
        }
    }
}