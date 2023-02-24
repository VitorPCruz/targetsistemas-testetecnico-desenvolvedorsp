using System.Text.Json.Serialization;

namespace TesteTecnico.Dominio.Questao3
{
    public class FaturamentoDiario
    {
        public FaturamentoDiario(int dia, decimal valor)
        {
            Dia = dia;
            Valor = valor;
        }

        [JsonPropertyName("dia")]
        public int Dia { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }
}
