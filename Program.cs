using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");
            Console.WriteLine($"4 * 2 = {Aritmetica.Multiplicar(4, 2)}");
            double temperaturaCelsius = Conversoes.ConverterTemperatura(36, Conversoes.ConversaoTemperatura.CelsiusParaFahrenheit);
            double temperaturaFahrenheit = Conversoes.ConverterTemperatura(100, Conversoes.ConversaoTemperatura.FahrenheitParaCelsius);

            Console.WriteLine($"36 °C = {temperaturaCelsius} °F");
            Console.WriteLine($"100 °F = {temperaturaFahrenheit} °C");

            Console.ReadKey();
        }
    }
}
