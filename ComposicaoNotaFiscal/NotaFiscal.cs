using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string DataRegistro { get; set; }
        public List<ItemNotaFiscal> Itens { get; set; }
        public NotaFiscal(int numeroNF, string dataRegistro)
        {
            NumeroNF = numeroNF;
            DataRegistro = dataRegistro;
            // a composição acontece agora, pois os objetos
            // NotaFiscal e Itens são instanciado juntos
            Itens = new List<ItemNotaFiscal>();
        }

        ~NotaFiscal(){
            Console.WriteLine("Destruir nota fiscal");
        }
    }
}