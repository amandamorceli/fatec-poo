namespace AgregacaoContaArray
{
    public class Cliente{
        public string Nome { get; set; }
        public int Rg { get; set; }
        public Cliente(string nome, int rg)
        {
            Nome = nome;
            Rg = rg;
        }
        public Cliente(){
            
        }
        public void MostrarDados()
        {
            Console.WriteLine("Nome: "+Nome+" - RG: "+Rg);
        }
    }
    
}