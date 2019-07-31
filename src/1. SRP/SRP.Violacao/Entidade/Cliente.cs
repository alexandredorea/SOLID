using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SRP.Violacao.Entidade
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (CPF.Length != 11)
                return "Cliente com CPF inválido";

            using (var conexao = new SqlConnection())
            {
                var comando = new SqlCommand
                {
                    //conexao.ConnectionString = "MinhaConnectionString";
                    Connection = conexao,
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))"
                };

                comando.Parameters.AddWithValue("nome", Nome);
                comando.Parameters.AddWithValue("email", Email);
                comando.Parameters.AddWithValue("cpf", CPF);
                comando.Parameters.AddWithValue("dataCad", DataCadastro);

                //conexao.Open();
                //comando.ExecuteNonQuery();
            }

            var mailMessage = new MailMessage("contato@empresa.com", Email);
            var clienteSmtp = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = "Bem-Vindo";
            mailMessage.Body = "Parabéns! Você está cadastrado.";
            //clienteSmtp.Send(mailMessage);

            return "Cliente cadastrado com sucesso!";
        }
    }
}