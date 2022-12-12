using System.Runtime.ConstrainedExecution;

namespace basico;

class Program 
{
    public static void Main(string[] args)
    {
        var escolha = 0;

        List<string[]> armazem = new List<string[]>();
        do
        {
            Console.WriteLine("\nQual operção deseja realizar?: \n1 - Cadastrar produto\r\n2 - Listar produtos cadastrados\r\n3 - Quantidade total de itens no estoque\r\n4 - Sair");
            escolha = Convert.ToInt16(Console.ReadLine());
            switch (escolha)
            {
                case 1: 
                    Console.WriteLine("\nDigite as informações do produto\nInforme o id do produto");
                    var id =  Console.ReadLine();
                    Console.WriteLine("Informe o nome do produto");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Informe a quantidade do produto");
                    var quantidade = Console.ReadLine();
                    string[] novoItem = { id!=null? id : "0", nome!=null? nome: "0", quantidade!= null ? quantidade : "0" };
                    armazem.Add(novoItem);
                    break;
                case 2: 
                    Console.WriteLine("\nLista de produtos: ");
                    Console.WriteLine("{0,-2} {1,-10} {2,5}\n", "Id", "Nome", "Quantidade");
                    armazem.ForEach(armazem =>
                    {
                        Console.WriteLine("{0,-2} {1,-10} {2,5}", armazem[0], armazem[1], armazem[2]);
                    });  
                    break;
                case 3:
                    var total = 0;
                    armazem.ForEach(produto =>
                    {
                        total += Convert.ToInt32(produto[2]);
                    });
                    Console.WriteLine("Quantidade total de itens no armazem: " + total); 
                    break;
                case 4: 
                    Console.WriteLine("Programa encerrado"); 
                    break;
                default: Console.WriteLine(); break;    
            }
        }while(escolha != 4);

    }

    

}
