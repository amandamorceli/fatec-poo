// main
using AgregacaoConta;

Cliente cli = new Cliente("Ana", 1234);

Conta c1 = new Conta(1, 100);
c1.Titular = cli; //agregação acontece agora. em c1.Titular, Titular ainda é objeto. quando recebe o objeto, passa a ser agregacao?
Console.WriteLine("Numero "+c1.Numero+"\nTitular: "+c1.Titular.Nome+" - RG: "+c1.Titular.Rg+"\nSaldo: "+c1.Saldo);

Conta c2 = new Conta(2,200);
c2.Titular = new Cliente(); // Construtor padrão
c2.Titular.Nome = "Bia";
c2.Titular.Rg = 5678;
Console.WriteLine("Numero "+c2.Numero+"\nTitular: "+c2.Titular.Nome+" - RG: "+c2.Titular.Rg+"\nSaldo: "+c2.Saldo);
