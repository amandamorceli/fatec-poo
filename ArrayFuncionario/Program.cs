//Main
using ArrayFuncionario;

/*
Criar um vetor de 3 elementos 
Cadastrar/digitar
Calcule o total de salarios de todos os funcionários com 1000 reais de salário 
informe se encontrou ou não
*/
double salarioTotal = 0;
Funcionario[] vetFunc = new Funcionario[3];

for (int i = 0; i < vetFunc.Length; i++)
{
    vetFunc[i] = new Funcionario();

Console.WriteLine("Insira o código: ");
vetFunc[i].codigo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira o nome: ");
vetFunc[i].nome = Console.ReadLine();
Console.WriteLine("Digite o salário: $");
vetFunc[i].salario = Convert.ToDouble(Console.ReadLine());
salarioTotal = vetFunc[i].salario + salarioTotal;

}
Console.WriteLine($"O total de salários de funcionários é de ${salarioTotal:c}");

foreach (Funcionario f in vetFunc)
    f.MostrarAtributos();    


