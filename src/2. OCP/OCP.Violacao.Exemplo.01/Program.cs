﻿using OCP.Violacao.Exemplo._01.Entidades;
using OCP.Violacao.Exemplo._01.Enumeradores;
using System;

namespace OCP.Violacao.Exemplo._01
{
    /// <summary>
    /// Classe que inicia o método Main() com violação sobre o conceito 
    /// Open Closed Principle (OCP) ou Princípio Aberto-Fechado
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada para o Console Application
        /// </summary>
        private static void Main()
        {
            var cliente = new Cliente();
            var totalCompra = cliente.ObterDesconto(TipoCliente.Especial, 200);

            //Resultado
            Console.WriteLine($"O total da compra é: {totalCompra}.");

            //Aguarda o usuário
            Console.ReadKey();
        }
    }
}
