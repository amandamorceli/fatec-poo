//função main

using ClasseFuncionario; // declarando o uso da classe Funcionario

Funcionario f1 = new Funcionario(); //definindo f1 como um objeto do tipo Funcionario e instaciando na mem

Console.Write("Digite o código: ");
f1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f1.nome=Console.ReadLine();
Console.Write("Digite o salário: $ ");
f1.salario=Convert.ToDouble(Console.ReadLine());
f1.MostrarAtributos(); //enviando uma mensagem
System.Console.Write("Digite a porcentagem que deseja aplicar para o funcionário: ");
double porcentagem = Convert.ToDouble(Console.ReadLine());

Funcionario f2 = new Funcionario();
Console.Write("Digite o código: ");
f2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
f2.nome=Console.ReadLine();
Console.Write("Digite o salário: $ ");
f2.salario=Convert.ToDouble(Console.ReadLine());
f2.MostrarAtributos();
double somaSalario = f1.salario + f2.salario;

f1.AumentarSalario(porcentagem);