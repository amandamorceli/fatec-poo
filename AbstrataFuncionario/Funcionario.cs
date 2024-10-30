using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        
        
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public abstract double CalcularSalario(int diasUteis);

        public virtual void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo}\t Nome: {Nome}\tSalário: {Salario:c}");
        }

        public Funcionario (int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }        
    }
}