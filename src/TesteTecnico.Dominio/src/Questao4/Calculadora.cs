namespace TesteTecnico.Dominio.Questao4
{
    public class Calculadora
    {
        public List<FaturamentoEstadual> ListaFaturamentoEstado { get; private set; } = new List<FaturamentoEstadual>();

        public Calculadora(List<FaturamentoEstadual> listaFaturamentoEstadual)
        {
            ValidarListaPreenchida(listaFaturamentoEstadual);
            ListaFaturamentoEstado.AddRange(listaFaturamentoEstadual);
        }

        public Dictionary<string, decimal> GerarPercentualFaturamentoEstado()
        {

            var dictFaturamento = new Dictionary<string, decimal>();

            foreach (var faturamento in ListaFaturamentoEstado)
            {
                var percentual = CalcularPercentualValor(faturamento.Valor);
                dictFaturamento.Add(faturamento.Estado, Math.Round(percentual, 2));
            }

            return dictFaturamento;
        }

        private decimal CalcularSomaFaturamentos()
        {
            return ListaFaturamentoEstado.Sum(x => x.Valor);
        }

        private decimal CalcularPercentualValor(decimal valor)
        {
            var total = CalcularSomaFaturamentos();
            return valor * 100 / total;
        }

        public void ValidarListaPreenchida(List<FaturamentoEstadual> lista)
        {
            if (lista.Count == 0)
                throw new InvalidOperationException("Não é possível prosseguir com a lista vazia.");
        }
    }
}
