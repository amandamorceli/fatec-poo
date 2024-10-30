
namespace ConstrutorProduto{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Qtde { get; set; }

        public Produto() //ctor abrevia criação do construtor
        {
            
        }

        public Produto(int codigo)
        {
            this.Codigo = codigo;
        }
        public Produto(string nome, int qtde, decimal preco)
        {
            this.Nome = nome;
            this.Qtde = qtde;
            this.Preco = preco;
        }
        // criar 3 construtores e apresenta-los
    }
}
