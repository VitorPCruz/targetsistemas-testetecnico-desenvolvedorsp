using System.ComponentModel;

namespace TesteTecnico.Dominio.Questao5
{
    public static class ExtensorString
    {
        public static string ReverterString(this string? str)
        {
            string resultado = "";

            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException("O valor n�o pode ser nulo ou preenchido com espa�os em branco.");

            for (int i = str!.Length; i > 0; i--)
                resultado += str[i - 1];

            return resultado;
        }
    }
}
