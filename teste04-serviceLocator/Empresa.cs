using System;

namespace teste04_serviceLocator
{
    public class Empresa
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        //public Endereco Endereco { get; set; } //auto grau de acoplamento
        public IEndereco Endreco { get; private set; } //acoplamento minimizado

        public Empresa()
        {
            this.Endreco = Localizador.GetEndereco();
        }
    }
}