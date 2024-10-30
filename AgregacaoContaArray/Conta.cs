namespace AgregacaoContaArray
{
    public class Conta
    {
        public int Numero { get; set; }
        // relacionamento entre classes, por meio do atributo Titular
        public List<Cliente> Titular { get; set; }// vetor CLiente 
        public double Saldo { get; set; }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;     
        }

        public void MostrarDados()
        {
            Console.WriteLine("Numero "+Numero+"\nSaldo: "+Saldo);
        }
    }
    
}