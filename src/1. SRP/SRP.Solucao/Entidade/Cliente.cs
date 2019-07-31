using SRP.Solucao.Servico;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRP.Solucao.Entidade
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        {
            return EmailServico.IsValid(Email) && CPFServico.IsValid(CPF);
        }
    }
}
