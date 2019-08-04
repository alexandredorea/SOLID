using OCP.Violacao.Exemplo._01.Enumeradores;

namespace OCP.Violacao.Exemplo._01.Entidades
{
    public class Cliente
    {
        public decimal ObterDesconto(TipoCliente tipoCliente, decimal TotalCompra)
        {
            if (tipoCliente == TipoCliente.Associado)
            {
                return TotalCompra - 25;
            }
            else if (tipoCliente == TipoCliente.Especial)
            {
                return TotalCompra - 50;
            }
            else if (tipoCliente == TipoCliente.Especial)
            {
                return TotalCompra - 75;
            }
            else
            {
                return TotalCompra;
            }
        }
    }
}
