namespace OCP.Validacao.Exemplo._02.Entidades.Base
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }

        public abstract string Debitar(string conta, decimal valor);
    }
}
