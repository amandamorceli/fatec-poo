using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

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