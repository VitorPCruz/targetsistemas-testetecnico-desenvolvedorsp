using TesteTecnico.Dominio.Questao5;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace TesteTecnico.Dominio.Tests.Questao5
{
    public class ExtensorStringTests
    {
        private readonly ITestOutputHelper _helper;
        public ExtensorStringTests(ITestOutputHelper helper)
        {
            _helper = helper;
        }

        [Theory(DisplayName = "Deve reverter a string com sucesso")]
        [Trait("ExtensorStringTests", "ExtensorString - Tests")]
        [InlineData("Comer banana")]
        [InlineData("Levantar peso")]
        [InlineData("Dominar o mundo")]
        public void ExtensorString_ReverterString_DeveRetornarUmaStringInvertidaComSucesso(string str)
        {
            // Arrange && Act
            string valor = str.ReverterString();

            // Assert
            Assert.Equal(str.Length, valor.Length);
            Assert.NotEqual(str, valor);

            // Pode visualizar os resultados deste teste habilitando o código abaixo.
            // _helper.WriteLine(str);
            // _helper.WriteLine(valor);
        }

        [Theory(DisplayName = "Deve retornar exception se valores invalidos")]
        [Trait("ExtensorStringTests", "ExtensorString - Tests")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("         ")]
        public void ExtensorString_ReverterString_DeveRetornarExceptionParaValoresInvalidos(string str)
        {
            // Arrange && Act && Assert
            Assert.Throws<ArgumentNullException>(() => str.ReverterString());
        }
    }
}
