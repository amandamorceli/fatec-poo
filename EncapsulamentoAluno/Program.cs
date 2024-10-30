//main

using EncapsulamentoAluno;

Aluno a1 = new Aluno();
a1.Matricula = 1; //set
a1.P1 = 7; //set
a1.P2 = 5.2; //set
a1.CalcularMedia();
Console.WriteLine("Média: "+a1.Media); //get
a1.Mostrar();