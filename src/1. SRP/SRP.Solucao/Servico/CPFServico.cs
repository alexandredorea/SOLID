namespace SRP.Solucao.Servico
{
    public static class CPFServico
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
