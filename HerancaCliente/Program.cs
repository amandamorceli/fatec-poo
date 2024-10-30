using HerancaCliente;

Cliente c = new Cliente(); //classe base
c.Codigo = 1;
c.Nome = "Ana";
c.Mostrar(); //método da classe Cliente / Super Classe

ClienteFisico cf = new ClienteFisico(); //classe superior
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Rg = 4890990;
cf.Cpf = 878729;
cf.Mostrar();

Cliente c2 = new Cliente(3, "Leo");
c2.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Lia", 3983094, 298294);
cf2.Mostrar();