using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Quantidade { get; set; }
        public ItemNotaFiscal(int quantidade)
        {
            Quantidade = 20;
        }
        ~ItemNotaFiscal() // esse é o destrutor da classe
        {
            
            Console.WriteLine("Destruir Item nota fiscal");
        }
    }
}