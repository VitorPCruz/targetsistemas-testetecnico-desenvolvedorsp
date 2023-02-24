namespace TesteTecnico.Dominio.Questao2
{
    public static class Fibonacci
    {
        // 2) Dado a sequ�ncia de Fibonacci, onde se inicia por 0 e 1 e o pr�ximo valor sempre ser� a soma dos 2 
        // valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que 
        // desejar onde, informado um n�mero, ele calcule a sequ�ncia de Fibonacci e retorne uma mensagem avisando 
        // se o n�mero informado pertence ou n�o a sequ�ncia.
        // IMPORTANTE:
        // Esse n�mero pode ser informado atrav�s de qualquer entrada de sua prefer�ncia ou pode ser previamente definido no c�digo;

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
                return $"O valor {valor} faz parte da sequ�ncia Fibonacci.";
            }
            return $"O valor {valor} nao faz parte da sequ�ncia Fibonacci.";
        }
    }
}