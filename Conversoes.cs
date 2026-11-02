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

       public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosParaMilhas,
            MilhasParaMetros
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

        /// <summary>
        /// Converte distância entre metros e milhas
        /// </summary>
        /// <param name="distancia"></param>
        /// <param name="tipoConversao"></param>
        /// <returns>retorna a distância convertida</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double ConverterDistancia(double distancia, ConversaoDistancia tipoConversao)
        {
            switch (tipoConversao)
            {
                case ConversaoDistancia.MetrosParaMilhas:
                    return distancia / 1609.34;
                case ConversaoDistancia.MilhasParaMetros:
                    return distancia * 1609.34;
                default:
                    throw new ArgumentException("Tipo de conversão inválido");
            }
        }


    }
}