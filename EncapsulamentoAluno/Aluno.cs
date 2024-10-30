
namespace EncapsulamentoAluno;
public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public double P1 { get; set; }
    public double P2 { get; set; }
    public double Media { get; private set; }

    //declaração dos métodos
    public void CalcularMedia()
    {
        Media = (P1+P2) / 2;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Matrícula: {Matricula}\nNome: {Nome}\nP1: {P1:n1}\nP2: {P2:n2}\nMedia: {Media:n3}.");
    }
}
