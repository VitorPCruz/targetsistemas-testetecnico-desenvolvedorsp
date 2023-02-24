using TesteTecnico.Dominio.Questao1;

namespace TesteTecnico.Dominio.Tests.Questao1
{
    public class ProcessamentoImprimirTests
    {
        [Fact(DisplayName = "Deve retornar SOMA igual � 91")]
        [Trait("ProcessamentoImprimrirTests", "Processamento Imprimrir - Tests")]
        public void Processamento_Imprimrir_DeveRetornar91EmSoma()
        {
            // Arrange && Act && Assert
            Assert.Equal(91, Processamento.Imprimir());
        }
    }
}
