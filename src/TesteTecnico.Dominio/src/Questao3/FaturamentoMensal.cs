using System.Collections.Generic;
using TesteTecnico.Dominio.Questao4;

namespace TesteTecnico.Dominio.Questao3
{
    public class FaturamentoMensal
    {
        public List<FaturamentoDiario> ListaFaturamento { get; private set;  } = new List<FaturamentoDiario>();

        public FaturamentoMensal(List<FaturamentoDiario> listaFaturamentoDiario)
        {
            ValidarListaPreenchida(listaFaturamentoDiario);
            ListaFaturamento.AddRange(listaFaturamentoDiario);
        }

        public decimal ObterMaiorFaturamentoMensal()
        {
            var maiorFaturamento = ListaFaturamento.Max(fd => fd.Valor);
            return Math.Round(maiorFaturamento, 2);
        }

        public decimal ObterMenorFaturamentoMensal()
        {
            var menorFaturamento = ListaFaturamento.OrderBy(fd => fd.Valor)
                .Min(fd => fd.Valor);

            return Math.Round(menorFaturamento, 2);
        }

        public decimal ObterMediaFaturamentoMensal()
        {
            var diasFaturados = ListaFaturamento.OrderBy(fd => fd.Valor)
                .Where(fd => fd.Valor > 0);
            var totalDiasFaturados = diasFaturados.Sum(fd => fd.Valor);

            var media = totalDiasFaturados / diasFaturados.Count();

            return Math.Round(media, 2);
        }

        public int ObterTotalDiasFaturadosAcimaDaMediaMensal()
        {
            var mediaMensal = ObterMediaFaturamentoMensal();
            var totalDias = ListaFaturamento.Count(fd => fd.Valor > mediaMensal);

            return totalDias;
        }

        public void ValidarListaPreenchida(List<FaturamentoDiario> lista)
        {
            if (lista.Count == 0)
                throw new InvalidOperationException("Não é possível prosseguir com a lista vazia.");
        }
    }
}
