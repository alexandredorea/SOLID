using OCP.Validacao.Exemplo._02.Entidades.Base;
using System;

namespace OCP.Validacao.Exemplo._02.Entidades
{
    public class ContaCorrente : DebitoConta
    {
        public override string Debitar(string conta, decimal valor)
        {
            // Lógica para Debita da Conta Corrente
            Console.WriteLine($"A conta corrente, número: {conta}, foi debitado um valor de {valor}.");
            return NumeroTransacao;
        }
    }
}
