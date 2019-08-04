using OCP.Validacao.Exemplo._01.Entidades;
using System;

namespace OCP.Validacao.Exemplo._01
{
    /// <summary>
    /// Classe que inicia o método Main() com validações sobre o conceito 
    /// Open Closed Principle (OCP) ou Princípio Aberto-Fechado
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada para o Console Application
        /// </summary>
        private static void Main()
        {
            var cliente = new ClienteAssociado();
            var totalCompra = cliente.ObterDesconto(200);

            //Resultado
            Console.WriteLine($"O total da compra é: {totalCompra}.");

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}