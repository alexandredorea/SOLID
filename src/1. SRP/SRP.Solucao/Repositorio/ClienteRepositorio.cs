using SRP.Solucao.Entidade;
using System.Data;
using System.Data.SqlClient;

namespace SRP.Solucao.Repositorio
{
    public class ClienteRepositorio
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var conexao = new SqlConnection())
            {
                var comando = new SqlCommand
                {
                    //conexao.ConnectionString = "MinhaConnectionString";
                    Connection = conexao,
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))"
                };

                comando.Parameters.AddWithValue("nome", cliente.Nome);
                comando.Parameters.AddWithValue("email", cliente.Email);
                comando.Parameters.AddWithValue("cpf", cliente.CPF);
                comando.Parameters.AddWithValue("dataCad", cliente.DataCadastro);

                //conexao.Open();
                //comando.ExecuteNonQuery();
            }
        }
    }
}
