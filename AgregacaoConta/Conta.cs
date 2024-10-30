namespace AgregacaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        // relacionamento entre classes, por meio do atributo Titular
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;     
        }
    }
    
}