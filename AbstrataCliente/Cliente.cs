using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;

        protected string nome;

        protected int idade;

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
        
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        

        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        
        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Código "+Codigo+"\tNome: "+Nome+"\tIdade:"+Idade);
        }
        public abstract void VerificarIdade(); 
        //Assinatura de método
        //saber se terá retorno
        //saber nome
        //saber se terá parâmetro
        // Na calsse abstrata, faz apenas a assinatura da função, definindo nome e o objetivo
        // as classes herdadas são responsáveis pela lógica 
    }
}