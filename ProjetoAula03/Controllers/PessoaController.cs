using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAula03.Entities;
using ProjetoAula03.Repositories;


namespace ProjetoAula03.Controllers
{
    public class PessoaController
    {
        //método para cadastrar pessoa no banco de dados
        public void CadastrarPessoa()
        {
            var pessoa = new Pessoa(); // instanciando a classe pessoa
            pessoa.Id = Guid.NewGuid(); // gerando um id unico

            Console.Write("INFORME O NOME DA PESSOA.....: ");
            pessoa.Nome = Console.ReadLine(); //lendo o nome da pessoa

            Console.Write("INFORME A DATA DE NASCIMENTO..: ");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

            var pessoaRepository = new PessoaRepository();
            // instanciando a classe
            pessoaRepository.Inserir(pessoa);
            Console.WriteLine("\nPESSOA CADASTRADA COM SUCESSO!");
        }
    }
}
