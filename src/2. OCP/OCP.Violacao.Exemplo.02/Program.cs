using OCP.Violacao.Exemplo._02.Entidades;
using OCP.Violacao.Exemplo._02.Enumeradores;
using System;

namespace OCP.Violacao.Exemplo._02
{
    /// <summary>
    /// Classe que inicia o método Main() para o conceito de violação do Open Closed Principle (OCP)
    /// Princípio Aberto-Fechado
    /// 
    /// IMPORTANTE: Esta solução atende ao Princípio da Responsabilidade Única, mas viola o Princípio 
    /// Aberto-Fechado
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada para o Console Application
        /// </summary>
        private static void Main()
        {
            var operacao = new DebitoConta();
            operacao.Debitar(10, "1234-0", TipoConta.Corrente);

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}
