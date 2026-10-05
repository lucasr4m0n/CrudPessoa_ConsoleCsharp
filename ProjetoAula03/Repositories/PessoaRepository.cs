using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using ProjetoAula03.Entities;

namespace ProjetoAula03.Repositories
{
    public class PessoaRepository
    {
        //declarar um atributo para armazenar a connectionstring
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetoAula03;Integrated Security=True;";

        //metódo para inserir um registro de pessoa no banco de dados
        public void Inserir(Pessoa pessoa)
        {
            //escrever a query SQL para execucao no banco de dados
            var query = "INSERT INTO PESSOA(ID, NOME, DATANASCIMENTO)  VALUES(@ID, @Nome, @DataNascimento)";

            //abrindo a conexao com o banco de dados
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando a query no banco de dados
                connection.Execute(query, pessoa);
            }
        }

        //método para atualizar um registro de pessoa no banco de dados
        public void Atualizar(Pessoa pessoa) { 
            //escrever a query SQL para execucao no banco de dados
            var query = "UPDATE PESSOA SET NOME = @Nome, DATANASCIMENTO = @DataNascimento WHERE ID = @ID";

            //abrindo conexao com o banco de dados
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando a query no banco de dados
                connection.Execute(query, pessoa);
            }
        }
        //método para excluir um registro de pessoa no banco de dados
        public void Excluir(Guid? id)
        {
            //escrever a query SQL para execucao no banco de dados
            var query = "DELETE FROM PESSOA WHERE ID = @Id";

            //abrindo conexao com o banco de dados
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando a query no banco de dados
                connection.Execute(query, new { id });
            }
        }

        //método para consultar todas as pessoas cadastradas no banco de dados
        public List<Pessoa> Consultar()
        {
            // escrever a query SQL para execucao no banco de dados 
            var query = "SELECT * FROM PESSOA ORDER BY NOME";

            //abrindo a conexao com o banco de dados 
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Pessoa>(query).ToList();
            }
        }
    }
}
