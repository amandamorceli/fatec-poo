using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        //declarar métodos de encapsulamento

        public int Quantidade // declarando a propriedade
        {
            get{ return quantidade;}
            set{
                if (value > 0)
                    this.quantidade = value;
                else
                    Console.WriteLine("Quantidade inválida!");
                }
        }

        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set {this.preco = value; }
        }
        
        public void AdicionarProduto(int quantidade)
        {
            quantidade = quantidade + quantidade;
            
        }

        public void RemoverProduto(int quantidade)
        {
            quantidade = quantidade - quantidade;
        }

        public double ValorTotalEstoque()
        {
            return quantidade*preco;
        }
        public void MostrarProduto()
        {
            Console.WriteLine("\nNome: "+nome+"\tQuantidade: "+quantidade+"\tPreço: $"+preco);
        }
    }
}