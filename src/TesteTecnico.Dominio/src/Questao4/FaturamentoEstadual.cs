namespace TesteTecnico.Dominio.Questao4
{
    public class FaturamentoEstadual
    {
        public FaturamentoEstadual(string estado, string valor)
        {
            Estado = estado;
            Valor = ConverterStringMoeda(valor);
        }

        public string Estado { get; private set; }
        public decimal Valor { get; private set; }

        public decimal ConverterStringMoeda(string valor)
        {
            return Convert.ToDecimal(valor.Replace("R$", "").Replace(".", "").Replace(",", "."));
        }
    }
}
