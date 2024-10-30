
namespace ConstrutorAluno
{
    public class Aluno
    {
        private long matricula = 1570482311000;
        private string nome;
        public static int contador;
    
        public Aluno()
        {
            contador++;
            this.matricula += contador;
        }

        public Aluno(string nome)
        {
            contador++;
            this.nome = nome;
            this.matricula += contador;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome do aluno: {nome}\tMatrícula: {matricula}\n");
        }
    }
}