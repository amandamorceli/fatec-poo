// função main
using ClasseProduto;

Produto prod1 = new Produto(); // produto do tipo produto

System.Console.Write("Insira o nome do produto: ");
prod1.nome = Console.ReadLine();
System.Console.Write("Insira o preço do produto: $");
prod1.preco = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Insira a quantidade do produto: ");
prod1.quantidade = Convert.ToInt32(Console.ReadLine());
prod1.AdicionarProduto(2);
prod1.RemoverProduto(1);
prod1.MostrarProduto();
System.Console.WriteLine("Valor total: $"+ prod1.ValorTotalEstoque());


