using ProjetoAula03.Controllers;

Console.WriteLine("\n*** SISTEMA DE GERENCIAMENTO DE PESSOAS: ***\n");

Console.WriteLine("(1) CADASTRAR PESSOA");
Console.WriteLine("(2) ATUALIZAR PESSOA");
Console.WriteLine("(3) EXCLUIR PESSOA");
Console.WriteLine("(4) CONSULTAR PESSOA");

Console.WriteLine("\nINFORME A OPCAO DESEJADA: ");
var opcao = Console.ReadLine();

var pessoaController = new PessoaController();

switch (opcao)
{
    case "1": pessoaController.CadastrarPessoa(); break;
    case "2": pessoaController.AtualizarPessoa(); break;
    case "3": pessoaController.ExcluirPessoa(); break;
    case "4": pessoaController.ConsultarPessoas(); break;
}


Console.ReadKey();