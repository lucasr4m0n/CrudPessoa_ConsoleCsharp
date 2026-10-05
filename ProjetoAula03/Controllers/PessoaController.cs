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

        //mmétodo para atualizar pessoa no banco de dados
        public void AtualizarPessoa()
        {
            var pessoa = new Pessoa();

            Console.Write("INFORME O ID DA PESSOA.....: ");
            pessoa.Id = Guid.Parse(Console.ReadLine());

            Console.Write("INFORME O NOME DA PESSOA.....: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("INFORME A DATA DE NASCIMENTO DA PESSOA.....: ");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

            var pessoaRepository = new PessoaRepository();
            pessoaRepository.Atualizar(pessoa);
            Console.WriteLine("\nPESSOA ATUALIZADA COM SUCESSO!");
        }

        //método para excluir pessoa no banco de dados
        public void ExcluirPessoa() 
        {
            Console.Write("INFORME O ID DA PESSOA.....: ");
            var id = Guid.Parse(Console.ReadLine());

            var pessoaRepository = new PessoaRepository();
            pessoaRepository.Excluir(id);
            Console.WriteLine("\nPESSOA EXCLUIDA COM SUCESSO!");
        }

        //método para consultar pessoas no banco de dados
        public void ConsultarPessoas()
        {
            var pessoaRepository = new PessoaRepository();
            var pessoas = pessoaRepository.Consultar();
            // retornando uma lista de pessoas

            //percorrendo cada pessoa contina na lista
            foreach(var item in pessoas)
            {
                Console.WriteLine("ID........: " + item.Id);
                Console.WriteLine("NOME DA PESSOA..: " + item.Nome);
                Console.WriteLine("DATA DE NASCIMENTO.: " + item.DataNascimento);
            }
        } 
    }
}
