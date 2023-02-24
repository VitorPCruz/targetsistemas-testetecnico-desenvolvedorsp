using System.Xml;

namespace TesteTecnico.Dominio.Questao3
{
    public class LeitorDeArquivosXML
    {
        public static List<FaturamentoDiario> ProcessarDados(string path)
        {
            try
            {
                var faturamentoMensal = new List<FaturamentoDiario>();

                var config = new XmlReaderSettings
                {
                    ConformanceLevel = ConformanceLevel.Fragment
                };

                using (XmlReader reader = XmlReader.Create(path, config))
                {
                    while (reader.Read())
                    {
                        var content = reader.ReadInnerXml()
                            .Trim()
                            .Replace("\n", "")
                            .Replace("\t", "")
                            .Replace("<dia>", "")
                            .Replace("</dia>", ",")
                            .Replace("<valor>", "")
                            .Replace("</valor>", "");

                        var comma = content.IndexOf(",");

                        var dia = int.Parse(content.Substring(0, comma));
                        var rendimento = decimal.Parse(content.Substring(comma + 1));

                        faturamentoMensal.Add(new FaturamentoDiario(dia, rendimento));
                    }

                    return faturamentoMensal;
                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
