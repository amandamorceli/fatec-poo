//criar a classe aluno, com os atributos matricula e nome OK
//utilizar o atibuto static para criar as matricula de forma automatica a cada isntancia seguindo o padrao fatec 1570482311035
//o atributo matricula nao sera static 
//utilize se quiser o atributo contador para auxiliar a contagem e registro da matricula
//criar o método mostrar e chamar após cada instancia
//instancie pelo menos 3 ojetos de construtores diferentes

//Main

using ConstrutorAluno;

Aluno a1 = new Aluno();
a1.MostrarAtributos();
Aluno a2 = new Aluno();
a2.MostrarAtributos();
Aluno a3 = new Aluno();
a3.MostrarAtributos();
Aluno a4 = new Aluno();
a4.MostrarAtributos();
Aluno a5 = new Aluno("Gabriela");
a5.MostrarAtributos();