using AbstrataCliente;

// Cliente c = new Cliente(1, "ana", 18);

// ClienteFisico cf = new ClienteFisico(2, "joão", 1111111);

ClienteFisico cf = new ClienteFisico(1, "Bia", 18, 222);
cf.MostrarAtributos();

Teste t = new Teste();
t.AvaliarIdade(cf);

ClienteJuridico cj = new ClienteJuridico(2, "João", 47, 333);
cj.MostrarAtributos();

Teste t2 = new Teste();
t2.AvaliarIdade(cj);