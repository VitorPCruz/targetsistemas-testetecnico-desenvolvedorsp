# Teste Técnico para vaga Desenvolvedor SP
## Descrição:
Teste técnico solicitado para vaga Desenvolvedor SP, da empresa Target Sistemas.

## IMPORTANTE:
- Não há modo Console na solução
- A camada _TesteTecnico.Dominio_ contém a lógica desenvolvida para as questões
- A camada _TesteTecnico.Dominio.Tests_ contém os testes desenvolvidos para o domínio
- Cada lógica de cada questão e seus respectivos testes estão separadas em pastas nomedas em Questão1, Questão2, etc., em cada camada
- Os testes podem ser executados via Visual Studio ou terminal, via ```dotnet test``` na pasta raiz da solução ou na pasta de solução dos testes
- Os arquivos disponibilizados para o teste não foram adulterados, com exceção do nome do arquivo dados.xml que ficou como dados(2).xml
- Os arquivos disponibilizados estão em TesteTecnico/src/TesteTecnico.Dominio.Tests/dados

## Descrição das Questões:
##### 1) Observe o trecho de código abaixo:
int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?
```Resposta: 91```

##### 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

##### 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
- O menor valor de faturamento ocorrido em um dia do mês;
- O maior valor de faturamento ocorrido em um dia do mês;
- Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
- a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
- b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

##### 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
- SP – R$67.836,43
- RJ – R$36.678,66
- MG – R$29.229,88
- ES – R$27.165,48
- Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
 
##### 5) Escreva um programa que inverta os caracteres de um string
IMPORTANTE:
- a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
- b) Evite usar funções prontas, como, por exemplo, reverse;

## Tecnologias Utilizadas:
- C#
- .NET 6

## Pacotes Utilizados:
- FluentAssertions
- xunit
- xunit.runner.visualstudio
- coverlet.collector

## Agradecimentos:
Agradeço à Target Sistemas pela possibilidade de participar do processo seletivo.
