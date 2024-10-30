using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }

        public ClienteFisico(int codigo, string nome, int idade, int rg): base (codigo, nome, idade)
        {
         Rg = rg;
        }

        public override void VerificarIdade()
        {
            if(Idade >=18 && Idade <= 45)
            Console.WriteLine("Cliente Físico");
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("RG: "+Rg);
        }
    }
}