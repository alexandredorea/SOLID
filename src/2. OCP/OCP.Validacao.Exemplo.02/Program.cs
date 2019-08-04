using OCP.Validacao.Exemplo._02.Entidades;
using System;

namespace OCP.Validacao.Exemplo._02
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
            var operacao = new ContaCorrente();
            var numeroTransacao = operacao.Debitar("1234-0", 10);

            //Resultado
            Console.WriteLine($"O número da transação gerado foi: {numeroTransacao}.");

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}
