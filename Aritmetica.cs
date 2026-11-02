namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas básicas
    /// </summary>
    internal static class Aritmetica
    {
        public enum ConversaoTemperatura
        {
            CelsiusParaFahrenheit,
            FahrenheitParaCelsius
        }

        /// <summary>
        /// Soma dois números inteiros e retorna o resultado
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>retorna a soma de 2 números inteiros</returns>
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtrai dois números inteiros e retorna o resultado
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>retorna a subtração de 2 números inteiros</returns>
        public staticint Subtrair(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Converte temperatura entre Celsius e Fahrenheit
        /// </summary>
        /// <param name="temperatura"></param>
        /// <param name="tipoConversao"></param>
        /// <returns>retorna a temperatura convertida</returns>
        public static double ConverterTemperatura(double temperatura, ConversaoTemperatura tipoConversao)
        {
            switch (tipoConversao)
            {
                case ConversaoTemperatura.CelsiusParaFahrenheit:
                    return (temperatura * 9/5) + 32;
                case ConversaoTemperatura.FahrenheitParaCelsius:
                    return (temperatura - 32) * 5/9;
                default:
                    throw new ArgumentException("Tipo de conversão inválido");
            }
        }
    }
}