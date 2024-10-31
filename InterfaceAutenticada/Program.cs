// Main()
using InterfaceAutenticada;

Cliente c = new Cliente();
c.Senha = 123;
IAutenticada ia = c;
Console.WriteLine(ia.Autentica(123));


Gerente g = new Gerente();
g.Senha = 456;
ia = g;
Console.WriteLine(ia.Autentica(456));

Diretor d = new Diretor();
d.Senha = 7890;
ia = d;
Console.WriteLine(ia.Autentica(780));
