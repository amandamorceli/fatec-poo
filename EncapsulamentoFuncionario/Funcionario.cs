using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        //atributos
        private int codigo;
        private string nome;
        private double salario;

        /* exemplo do uso encaplsulamento mais detalhado e parecido com Java e PHP
        
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return this.codigo;
        }
        */

        public int Codigo // propriedade
        {
            set{
                this.codigo = value;
            }
            get{
                return codigo;
            }
        }

        public string Nome
        {
            set{
                this.nome = value;
            }
            get{
                return this.nome;
            }
        }

        public double Salario
        {
            set{
                this.salario = value;
            }
            get{
                return this.salario;
            }
        }
        public void MostrarAtributos() //método, operador de ação
        {
            Console.WriteLine("\tCódigo: " + codigo + "\tNome: " + nome + "\tSalário: $ " + salario);
        }
        //criar um método para aplicar uma porcentagem de aumento do salário

        public void AumentarSalario(double porcentagem)
        {
            salario += salario + porcentagem / 100;
        }
    }
}