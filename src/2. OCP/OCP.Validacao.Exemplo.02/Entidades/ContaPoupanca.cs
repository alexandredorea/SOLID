using OCP.Validacao.Exemplo._02.Entidades.Base;
using System;

namespace OCP.Validacao.Exemplo._02.Entidades
{
    public class ContaPoupanca : DebitoConta
    {
        public override string Debitar(string conta, decimal valor)
        {
            // Valida Aniversário da Conta
            // Lógica para Debita da Poupança
            Console.WriteLine($"A conta poupança, número: {conta}, foi debitado um valor de {valor}.");
            return NumeroTransacao;
        }
    }
}
