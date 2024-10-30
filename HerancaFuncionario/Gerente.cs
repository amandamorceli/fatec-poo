namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario): base(codigo, nome, salario)
        {}
        public override double CalcularBonificacao()
        {
            return Salario * 15/100;
        }
    }
}