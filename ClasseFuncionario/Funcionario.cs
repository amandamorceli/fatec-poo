using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        //atributos
        public int codigo;
        public string nome;
        public double salario;
        public void MostrarAtributos() //método, operador de ação
        {
            Console.WriteLine("\tCódigo: "+codigo+"\tNome: "+nome+"\tSalário: $ "+salario);
        }
        //criar um método para aplicar uma porcentagem de aumento do salário

        public void AumentarSalario(double porcentagem){
            salario += salario + porcentagem / 100;
        }
    }
}