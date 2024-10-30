using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Cliente(int codigo, string nome) //construtor construido na classe pai, é obrigatorio construtor se construido na classe filho
        {
            Codigo = codigo;
            Nome= nome;
        }
        public Cliente()
        {
            
        }

        public void Mostrar()
        {
            Console.WriteLine($"Código: {codigo} \tNome: {nome}");
        }
    }
}