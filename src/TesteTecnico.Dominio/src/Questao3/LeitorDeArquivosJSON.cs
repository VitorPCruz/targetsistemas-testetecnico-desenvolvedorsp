using System.Text.Json;

namespace TesteTecnico.Dominio.Questao3
{
    public class LeitorDeArquivosJSON
    {
        public static List<FaturamentoDiario> ProcessarDados(string path)
        {
            try
            {
                var jsonString = File.ReadAllText(path);
                var faturamentoMensal = JsonSerializer.Deserialize<List<FaturamentoDiario>>(jsonString);
                return faturamentoMensal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}