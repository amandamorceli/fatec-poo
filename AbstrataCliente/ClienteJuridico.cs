using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, int cnpj): base (codigo, nome, idade)
        {
            Cnpj = cnpj;
        }

        public override void VerificarIdade()
        {
            if(Idade > 46)
            Console.WriteLine("Cliente Jurídico");
        }
        
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            System.Console.WriteLine("4444");
            Console.WriteLine("CNPJ: "+Cnpj);
        }
    }
}