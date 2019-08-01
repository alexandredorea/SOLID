using OCP.Violacao.Exemplo._02.Enumeradores;
using System;

namespace OCP.Violacao.Exemplo._02.Entidades
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Lógica para Debita da Poupança
                Console.WriteLine($"A conta poupança, número: {conta}, foi debitado um valor de {valor}.");
            }
            if (tipoConta == TipoConta.Corrente)
            {
                // Lógica para Debita da Conta Corrente
                Console.WriteLine($"A conta corrente, número: {conta}, foi debitado um valor de {valor}.");
            }
        }
    }
}
