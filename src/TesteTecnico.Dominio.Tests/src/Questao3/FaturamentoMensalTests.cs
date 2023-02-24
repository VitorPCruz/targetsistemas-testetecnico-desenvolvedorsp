using FluentAssertions;
using TesteTecnico.Dominio.Questao3;

namespace TesteTecnico.Dominio.Tests.Questao3
{
    public class FaturamentoMensalTests
    {
        private readonly List<FaturamentoDiario> _listaFaturamentoDiarioJSON;
        private readonly List<FaturamentoDiario> _listaFaturamentoDiarioXML;
        private readonly FaturamentoMensal _faturamentoMensalJSON;
        private readonly FaturamentoMensal _faturamentoMensalXML;

        public FaturamentoMensalTests()
        {
            _listaFaturamentoDiarioJSON = LeitorDeArquivosJSON.ProcessarDados(Paths.JSONFile);
            _listaFaturamentoDiarioXML = LeitorDeArquivosXML.ProcessarDados(Paths.XMLFile);
            _faturamentoMensalJSON = new FaturamentoMensal(_listaFaturamentoDiarioJSON);
            _faturamentoMensalXML = new FaturamentoMensal(_listaFaturamentoDiarioXML);
        }


        [Fact(DisplayName = "Faturamento deve retornar exception se lista vazia")]
        [Trait("FaturamentoMensalTests", "Faturamento Mensal - Tests")]
        public void FaturamentoMensal_ValidarListaPreenchida_DeveLevantarExceptioSeListaVazia()
        {
            // Arrange && Act && Assert
            Assert.Throws<InvalidOperationException>(() => new FaturamentoMensal(new List<FaturamentoDiario>()));
        }


        [Fact(DisplayName = "Faturamento JSON/XML deve retornar maior faturamento mensal")]
        [Trait("FaturamentoMensalTests", "Faturamento Mensal - Tests")]
        public void FaturamentoMensal_ObterMaiorFaturamentoMensal_DeveRetornarMaiorFaturamentoComSucesso()
        {
            // Arrange && Act
            var maiorFaturamentoMensalJSON = _faturamentoMensalJSON.ObterMaiorFaturamentoMensal();
            var maiorFaturamentoMensalXML = _faturamentoMensalXML.ObterMaiorFaturamentoMensal();

            // Assert
            maiorFaturamentoMensalJSON.Should().BeGreaterThanOrEqualTo(48924);
            maiorFaturamentoMensalXML.Should().BeGreaterThanOrEqualTo(48275);
        }


        [Fact(DisplayName = "Faturamento JSON/XML deve retornar menor faturamento mensal")]
        [Trait("FaturamentoMensalTests", "Faturamento Mensal - Tests")]
        public void FaturamentoMensal_ObterMenorFaturamentoMensal_DeveRetornarMenorFaturamentoComSucesso()
        {
            // Arrange && Act
            var menorFaturamentoMensalJSON = _faturamentoMensalJSON.ObterMenorFaturamentoMensal();
            var menorFaturamentoMensalXML = _faturamentoMensalXML.ObterMenorFaturamentoMensal();

            // Assert
            menorFaturamentoMensalJSON.Should().Be(0);
            menorFaturamentoMensalXML.Should().Be(0);
        }


        [Fact(DisplayName = "Faturamento JSON/XML deve retornar dias acima da média")]
        [Trait("FaturamentoMensalTests", "Faturamento Mensal - Tests")]
        public void FaturamentoMensal_ObterMaiorFaturamentoMensal_DeveRetornarDiasAcimaDaMedia()
        {
            // Arrange && Act
            var diaAcimaMediaJSON = _faturamentoMensalJSON.ObterTotalDiasFaturadosAcimaDaMediaMensal();
            var diaAcimaMediaXML  = _faturamentoMensalXML.ObterTotalDiasFaturadosAcimaDaMediaMensal();

            // Assert
            diaAcimaMediaJSON.Should().Be(10);
            diaAcimaMediaXML.Should().Be(11);
        }
    }
}
