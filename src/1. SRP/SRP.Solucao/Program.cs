using SRP.Solucao.Entidade;
using SRP.Solucao.Servico;
using System;

namespace SRP.Solucao
{
    /// <summary>
    /// Classe que inicia o método Main() para o conceito correto do Single Responsibility Principle (SRP)
    /// Princípio da Responsabilidade Única
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada para o Console Application
        /// </summary>
        private static void Main()
        {
            var cliente = new Cliente
            {
                ClienteId = 1,
                Nome = "Alexandre Dórea",
                CPF = "12345678900",
                Email = "alexandre.dorea@gmail.com",
                DataCadastro = DateTime.Now
            };
            var servicoCliente = new ClienteServico();

            //Resultado
            Console.WriteLine(servicoCliente.AdicionarCliente(cliente));

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}
