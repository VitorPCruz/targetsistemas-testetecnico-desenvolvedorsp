namespace TesteTecnico.Dominio.Questao1;

public class Processamento
{
    // 1) Observe o trecho de c�digo abaixo:
    // int INDICE = 13, SOMA = 0, K = 0;
    // enquanto K<INDICE fa�a
    // {
    //     K = K + 1;
    //     SOMA = SOMA + K;
    // }
    // imprimir(SOMA);
    // Ao final do processamento, qual ser� o valor da vari�vel SOMA?
    // Resposta: O valor do processamento da vari�vel SOMA ser� 91

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
