using SRP.Violacao.Entidade;
using System;

namespace SRP.Violacao
{
    /// <summary>
    /// Classe que inicia o método Main() para o conceito de violação do Single Responsibility Principle (SRP)
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

            //Resultado
            Console.WriteLine(cliente.AdicionarCliente());

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}
