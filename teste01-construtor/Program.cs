using System;

namespace teste01_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA e1 = new EnderecoA();
            e1.Rua = "Rua B";
            e1.Numero = 65;
            
            EnderecoB e2 = new EnderecoB();
            e2.Cidade = "Porto Alegre";
            e2.UF = "RS";
            
            //empresa recebe 2 endereços implementados diferentes, mas com a interface migual
            //a aplicação que decide qual usar internamente
            Empresa empresa1 = new Empresa(e1);
            Empresa empresa2 = new Empresa(e2);
            
        }
    }
}