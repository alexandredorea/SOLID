using OCP.Validacao.Exemplo._02.Entidades.Base;
using System;

namespace OCP.Validacao.Exemplo._02.Entidades
{
    public class ContaInvestimento : DebitoConta
    {
        public override string Debitar(string conta, decimal valor)
        {
            // Lógica para Debita de Investimento
            // Isenta de Taxas
            Console.WriteLine($"A conta investimento, número: {conta}, foi debitado um valor de {valor}.");
            return NumeroTransacao;
        }
    }
}
