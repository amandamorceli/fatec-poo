// main AgregacaoContaArray
using AgregacaoContaArray;

Cliente cli1 = new Cliente("Ana", 11);
Cliente cli2 = new Cliente("Bia", 22);

Conta c1 = new Conta(1,10000);
c1.Titular = new List<Cliente>();
c1.Titular.Add(cli1); //Add é um método da classe List para adicionar ao vetor
c1.Titular.Add(cli2);

Console.WriteLine("--------- Apresentação da conta ---------");
c1.MostrarDados();
foreach (Cliente c in c1.Titular)
{
    c.MostrarDados();    
}