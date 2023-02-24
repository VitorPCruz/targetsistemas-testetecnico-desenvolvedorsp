using TesteTecnico.Dominio.Questao4;
using Xunit.Abstractions;

namespace TesteTecnico.Dominio.Tests.Questao4
{
    public class CalculadoraTests
    {
        private readonly ITestOutputHelper _helper;
        public CalculadoraTests(ITestOutputHelper helper)
        {
            _helper = helper;
        }

        [Fact(DisplayName = "Deve gerar um dicionário com os percentuais de cada estado")]
        [Trait("CalculadoraTests", "Calculadora - Tests")]
        public void Calculadora_GerarPercentualFaturamentoEstado_DeveGerarPercentuais()
        {
            // Arrange
            var calculadora = new Calculadora(
                new List<FaturamentoEstadual>
                {
                    new FaturamentoEstadual("SP", "R$67.836,43"),
                    new FaturamentoEstadual("RJ", "R$36.678,66"),
                    new FaturamentoEstadual("MG", "R$29.229,88"),
                    new FaturamentoEstadual("ES", "R$27.165,48"),
                    new FaturamentoEstadual("Outros", "R$19.849,53")
                });

            // Act
            var resultados = calculadora.GerarPercentualFaturamentoEstado();

            // Assert
            Assert.Equal(5, resultados.Count);
            Assert.Contains((decimal)37.53, resultados.Values);
            Assert.Contains((decimal)20.29, resultados.Values);
            Assert.Contains((decimal)16.17, resultados.Values);
            Assert.Contains((decimal)15.03, resultados.Values);
            Assert.Contains((decimal)10.98, resultados.Values);
        }

        [Fact(DisplayName = "Deve retornar exception se lista estiver vazia ao calcular")]
        [Trait("CalculadoraTests", "Calculadora - Tests")]
        public void Calculadora_GerarPercentualFaturamentoEstado_DeveRetornarExceptionSeListaVazia()
        {
            // Arrange && Act && Assert
            Assert.Throws<InvalidOperationException>(() => 
                new Calculadora(new List<FaturamentoEstadual>()));
        }
    }
}
