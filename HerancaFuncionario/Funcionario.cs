namespace HerancaFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
       {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;            
        }

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine($"Funcionário:\nCódigo: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 10/100;
        }

    }
}