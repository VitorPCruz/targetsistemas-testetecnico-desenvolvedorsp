using FluentAssertions;
using TesteTecnico.Dominio.Questao2;

namespace TesteTecnico.Dominio.Tests.Questao2
{
    public class FibonacciTests
    {
        [Theory(DisplayName = "Deve retornar TRUE se faz parte da sequencia Fibonacci")]
        [Trait("Fiboncci", "Fibonacci - Tests")]
        [InlineData(13)]
        [InlineData(21)]
        [InlineData(34)]
        [InlineData(55)]
        [InlineData(233)]
        [InlineData(377)]
        public void Fibonacci_VerificarFibonacci_DeveRetornarTrueSeFizerParteDaSequenciaFibonacci(int valor)
        {
            // Arrange && Act
            bool resultado = Fibonacci.VerificarFibonacci(valor);

            // Assert
            resultado.Should().BeTrue();
        }

        [Theory(DisplayName = "Deve retornar FALSE se NAO faz parte da sequencia Fibonacci")]
        [Trait("Fiboncci", "Fibonacci - Tests")]
        [InlineData(7)]
        [InlineData(24)]
        [InlineData(102)]
        [InlineData(123)]
        [InlineData(394)]
        public void Fibonacci_VerificarFibonacci_DeveRetornarFalseSeFizerParteDaSequenciaFibonacci(int valor)
        {
            // Arrange && Act
            bool resultado = Fibonacci.VerificarFibonacci(valor);

            // Assert
            resultado.Should().BeFalse();
        }

        [Theory(DisplayName = "Deve retornar MENSAGEM se faz parte da sequencia Fibonacci")]
        [Trait("Fiboncci", "Fibonacci - Tests")]
        [InlineData(13)]
        [InlineData(21)]
        [InlineData(34)]
        [InlineData(55)]
        [InlineData(233)]
        [InlineData(377)]
        public void Fibonacci_EhFibonacci_DeveRetornarMensagemDeConfirmacao(int valor)
        {
            // Arrange && Act
            string mensagem = Fibonacci.EhFibonacci(valor);

            // Assert
            mensagem.Should().Be($"O valor {valor} faz parte da sequência Fibonacci.");
        }

        [Theory(DisplayName = "Deve retornar MENSAGEM SE NAO faz parte da sequencia Fibonacci")]
        [Trait("Fiboncci", "Fibonacci - Tests")]
        [InlineData(7)]
        [InlineData(24)]
        [InlineData(102)]
        [InlineData(123)]
        [InlineData(394)]
        public void Fibonacci_EhFibonacci_DeveRetornarMensagemDeNegacao(int valor)
        {
            // Arrange && Act
            string mensagem = Fibonacci.EhFibonacci(valor);

            // Assert
            mensagem.Should().Be($"O valor {valor} nao faz parte da sequência Fibonacci.");
        }
    }
}