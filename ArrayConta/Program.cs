// Main()
using ArrayConta;

//declarar o vetor de objetos
Conta[] vetConta = new Conta[3];

//manipular o vetor instanciando e cadastrando
for (int i = 0; i < vetConta.Length; i++)
{
    vetConta[i] = new Conta();
    Console.Write("Cadastre o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Cadastre o titular: ");
    vetConta[i].titular = Console.ReadLine();
    Console.Write("Cadastre o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetConta)
    c.MostrarAtributos();
