using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> vetFuncionario { get; set; }

        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo}\tDescrição: {Descricao}");
        }

        public void Admitir(Funcionario funcionario)
        {
            vetFuncionario.Add(funcionario);
        }
        public void Listar()
        {
            foreach (Funcionario funcionario in vetFuncionario)
            {
                funcionario.MostrarAtributos();
            }
        }
    }
}