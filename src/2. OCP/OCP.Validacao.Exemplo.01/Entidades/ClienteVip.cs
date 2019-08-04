using OCP.Validacao.Exemplo._01.Entidades.Base;

namespace OCP.Validacao.Exemplo._01.Entidades
{
    public class ClienteVip : Cliente
    {
        public override decimal ObterDesconto(decimal TotalCompra)
        {
            return TotalCompra - 75;
        }
    }
}
