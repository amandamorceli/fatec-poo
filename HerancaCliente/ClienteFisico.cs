using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente
    {
        private int cpf;
        private int rg;
        public int Cpf 
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public int Rg
        {
            get { return rg;}
            set { rg = value; }
        }
        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo, nome) // obs: parametros na ordem
        {
            Cpf = cpf;
            Rg = rg;
        }
        public ClienteFisico():base()
        {
            
        }

        // base() - chama o construtor
        // base.<método> - chama um método da classe base

        public void Mostrar()
        {
            base.Mostrar(); // para apresentar o código e o nome
            Console.WriteLine($"RG: {rg}\tCPF: {cpf}");
        }
    }
}