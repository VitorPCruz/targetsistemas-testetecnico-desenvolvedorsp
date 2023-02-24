namespace TesteTecnico.Dominio.Questao2
{
    public static class Fibonacci
    {
        // 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 
        // valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que 
        // desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando 
        // se o número informado pertence ou não a sequência.
        // IMPORTANTE:
        // Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

        public static bool VerificarFibonacci(int valor)
        {
            int auxiliar1 = 0;
            int auxiliar2 = 1;

            for (int i = 0; auxiliar2 < valor; i++)
            {
                int temp = auxiliar1;
                auxiliar1 = auxiliar2;
                auxiliar2 = temp + auxiliar2;
            }

            if (auxiliar2 == valor)
            {
                return true;
            }
            return false;
        }

        public static string EhFibonacci(int valor)
        {
            bool resultado = VerificarFibonacci(valor);

            if (resultado)
            {
                return $"O valor {valor} faz parte da sequência Fibonacci.";
            }
            return $"O valor {valor} nao faz parte da sequência Fibonacci.";
        }
    }
}