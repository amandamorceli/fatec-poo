//main
using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();

/* exemplo do uso encaplsulamento mais detalhado e parecido com Java e PHP
f1.setCodigo(1);
Console.WriteLine("Código: "+f1.getCodigo());*/

f1.Codigo = 1; //aqui é executado o método set
f1.Nome = "João";
f1.Salario = 1200.5;
System.Console.WriteLine($"Código: {f1.Codigo}, Nome: {f1.Nome}, Salário: R${f1.Salario}."); //aqui é executado o get
//if(f1.Codigo == 3){} busca
