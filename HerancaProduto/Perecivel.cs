using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel:Produto
    {
        private string dtFabricacao;

        private string dtValidade;
        
        private int lote;

        public string DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }

        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }

        public int Lote        
        {
            get { return lote; }
            set { lote = value; }
        }

        public Perecivel():base()
        {

        }

        public Perecivel(int codigo, string nome, double preco, string dtFabricacao, string dtValidade, int lote):base(codigo, nome, preco)
        {
            DtFabricacao = dtFabricacao;
            DtValidade = dtValidade;
            Lote = lote;
        }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"DtF: {dtFabricacao}\tDtV: {dtValidade}\tLote: {lote}");
        }

    }
}