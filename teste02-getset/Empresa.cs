using System;

namespace teste02_getset
{
    public class Empresa
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        //public Endereco Endereco { get; set; } //auto grau de acoplamento
        private IEndereco _endereco; //acoplamento minimizado

        public IEndereco Endereco
        {
            get { return this._endereco; }
            set { this._endereco = value; }
        }
        
    }
}