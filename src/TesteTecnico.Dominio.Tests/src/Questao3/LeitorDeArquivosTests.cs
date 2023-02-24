using FluentAssertions;
using TesteTecnico.Dominio.Questao3;

namespace TesteTecnico.Dominio.Tests.Questao3
{
    public class LeitorDeArquivosTests
    {
        [Fact(DisplayName = "LeitorDeArquivosXML deve ler um arquivo arquivo XML com sucesso")]
        [Trait("LeitorDeArquivosTests", "LeitorDeArquivos - Tests")]
        public void LeitorDeArquivosXML_ProcessarDados_DeveRetornarListaDeDadosProcessados()
        {
            // Arrange && Act 
            var dados = LeitorDeArquivosXML.ProcessarDados(Paths.XMLFile);

            // Assert
            dados.Should().HaveCount(30);
        }

        [Fact(DisplayName = "LeitorDeArquivosXML deve retornar exception se arquivo ou caminho invalido")]
        [Trait("LeitorDeArquivosTests", "LeitorDeArquivos - Tests")]
        public void LeitorDeArquivosXML_ProcessarDados_DeveRetornarExceptionSeArquivoOuPathIncorretos()
        {
            // Arrange && Act && Assert
            Assert.Throws<Exception>(() => LeitorDeArquivosXML.ProcessarDados(Paths.XMLFile + "s"));
        }

        [Fact(DisplayName = "LeitorDeArquivosJSON deve ler um arquivo arquivo JSON com sucesso")]
        [Trait("LeitorDeArquivosTests", "LeitorDeArquivos - Tests")]
        public void LeitorDeArquivosJSON_ProcessarDados_DeveRetornarListaDeDadosProcessados()
        {
            // Arrange && Act
            var dados = LeitorDeArquivosJSON.ProcessarDados(Paths.JSONFile);

            // Assert
            dados.Should().HaveCount(30);
        }

        [Fact(DisplayName = "LeitorDeArquivosJSON deve retornar exception se arquivo ou caminho invalido")]
        [Trait("LeitorDeArquivosTests", "LeitorDeArquivos - Tests")]
        public void LeitorDeArquivosJSON_ProcessarDados_DeveRetornarExceptionSeArquivoOuPathIncorretos()
        {
            // Arrange && Act && Assert
            Assert.Throws<Exception>(() => LeitorDeArquivosJSON.ProcessarDados(Paths.JSONFile + "s"));
        }
    }
}
