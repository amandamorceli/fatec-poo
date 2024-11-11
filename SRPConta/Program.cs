//main
using SRPConta;

Conta conta1 = new Conta("amanda");
conta1.Saldo=20;

GerarRelatórios g1 = new GerarRelatórios();
g1.GeraRelatórios(conta1.Titular, conta1.Saldo);
