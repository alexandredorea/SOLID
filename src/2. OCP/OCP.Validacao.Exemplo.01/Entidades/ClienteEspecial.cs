using OCP.Validacao.Exemplo._01.Entidades.Base;

namespace OCP.Validacao.Exemplo._01.Entidades
{
    public class ClienteEspecial : Cliente
    {
        public override decimal ObterDesconto(decimal TotalCompra)
        {
            return TotalCompra - 50;
        }
    }
}
