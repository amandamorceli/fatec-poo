// fç Main()
using Classe;

// instanciando objetos
Conta conta1; //declaração de uma variável do tipo Conta
conta1 = new Conta(); //instancia de objeto do new pra frente
conta1.numero = 1;
conta1.titular = "FATEC";
conta1.saldo = 100;

Conta conta2 = new Conta(); // Conta: tipo da classe; conta2: variavel; new: alocação de memoria; Conta(): construtor da classe
conta2.numero = 2;
conta2.titular = "Empresa Jr.";
conta2.saldo = 200;

conta2.Transferencia(50, conta1);

Console.WriteLine("\nNúmero: " + conta1.numero + "\tTitular: "
 + conta1.titular+"\tSaldo: " + conta1.saldo);
 Console.WriteLine("\nNúmero: " + conta2.numero + "\tTitular: "
 + conta2.titular+"\tSaldo: " + conta2.saldo);


/*
/Console.WriteLine("\nNúmero: " + conta1.numero +"\tTitular: "
 + conta1.titular + "\tSaldo: " + conta1.saldo);
Console.WriteLine("\nNúmero: " + conta2.numero + "\tTitular: "
 + conta2.titular+"\tSaldo: " + conta2.saldo);

Conta conta3 = new Conta();
Console.Write("Cadastre o número da conta: ");
conta3.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Cadastre o titular: ");
conta3.titular= Console.ReadLine();
Console.Write("Cadastre o saldo: ");
conta3.saldo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nNúmero: " + conta3.numero + "\tTitular: "
 + conta3.titular+"\tSaldo: " + conta3.saldo);
*/ 