using HerancaFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
f.MostrarAtributos();
Console.WriteLine($"Bonificação: {f.CalcularBonificacao():c}");

Secratario s = new Secratario(2, "Leo", 1000);
s.MostrarAtributos();
Console.WriteLine($"Bonificação: {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Joao", 1000);
g.MostrarAtributos();
Console.WriteLine($"Bonificação: {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Maria", 1000);
d.MostrarAtributos();
Console.WriteLine($"Bonificação: {d.CalcularBonificacao():c}");