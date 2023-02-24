namespace TesteTecnico.Dominio.Questao1;

public class Processamento
{
    // 1) Observe o trecho de código abaixo:
    // int INDICE = 13, SOMA = 0, K = 0;
    // enquanto K<INDICE faça
    // {
    //     K = K + 1;
    //     SOMA = SOMA + K;
    // }
    // imprimir(SOMA);
    // Ao final do processamento, qual será o valor da variável SOMA?
    // Resposta: O valor do processamento da variável SOMA será 91

    public static int Imprimir(int indice = 13, int soma = 0, int k = 0)
    {
        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }
        return soma;
    }
}
