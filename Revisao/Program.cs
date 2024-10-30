internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int  idade = 2024 - ano;
        Console.WriteLine("Sua idade é " + idade);
        if(idade >- 18){
            Console.WriteLine("Maior de idade.");
            }
        else if(idade ==1){
            Console.WriteLine("É um bebe.");
        }
        else
        {
            Console.WriteLine("Menor de idade.");
        }
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine("5 x "+ contador +" = "+ contador*5 );
            contador ++;
        }
        for (int cont = 1; cont <= 10; cont++)
            Console.WriteLine("5 x "+ cont +" = "+ cont*5);
    
        int cont = 1;
        do
        {
            Console.WriteLine("5 x "+ cont +" = "+ cont*5);
            cont++;
        } while (cont <= 10);

    estrutura de dec de multipla escolha
    
    int opcao = 1;
    switch(opcao)
    {
        case 1: Console.WriteLine("1 - SOMAR");
        break;

        case 2: Console.WriteLine("2 - SUBTRAIR");
        break;

        default: Console.WriteLine("Opção inválida!");
        break; 
    }
     float media = 8;
     Console.WriteLine((media >= 6)? "Aprovado": "Reprovado");
     */
    int[] vet = new int[3];

    vet[0] = 12;
    vet[1] = 50;
    vet[2] = 67;

    foreach (int v in vet)
        Console.WriteLine(v);
        
    Console.WriteLine("----------------");
    Console.WriteLine("Exemplo com for");
    for (int i = 0; i < vet.Length; i++)
    {
        Console.WriteLine(vet[i]);
    }

    }
}
