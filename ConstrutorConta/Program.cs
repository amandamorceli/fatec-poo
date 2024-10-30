//main

using ConstrutorConta;

Conta c1 = new Conta();
Console.WriteLine($"Quantidade de instâncias:{Conta.Contador}");
c1.MostrarAtributos();

Conta c2 = new Conta(20);
Console.WriteLine($"Quantidade de instâncias:{Conta.Contador}");
c2.MostrarAtributos();

Conta c3 = new Conta(30, "Ana");
Console.WriteLine($"Quantidade de instâncias:{Conta.Contador}");
c3.MostrarAtributos();

Conta c4 = new Conta(40, "Luiz", 520.4);
Console.WriteLine($"Quantidade de instâncias:{Conta.Contador}");
c4.MostrarAtributos();