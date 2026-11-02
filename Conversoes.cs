namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class  Conversoes
    {
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusParaFahrenheit,
            FahrenheitParaCelsius
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