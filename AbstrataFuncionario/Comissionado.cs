using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Comissionado : Funcionario
    {
        private double porcentagem;
        public double Porcentagem
        {
            get { return porcentagem; }
            set { porcentagem = value; }
        }
        
        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30 *diasUteis) * porcentagem + Salario;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine($"Porcentagem {Porcentagem:c}");
        }

        public Comissionado(int codigo, string nome, double salario, double porcentagem):base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
    }
}