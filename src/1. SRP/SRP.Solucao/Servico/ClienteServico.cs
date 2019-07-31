using SRP.Solucao.Entidade;
using SRP.Solucao.Repositorio;

namespace SRP.Solucao.Servico
{
    public class ClienteServico
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.AdicionarCliente(cliente);

            EmailServico.Enviar("empresa@empresa.com", cliente.Email, "Bem-Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
