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
            Console.WriteLine($"0 °C = {Aritmetica.ConverterTemperatura(0, Aritmetica.ConversaoTemperatura.CelsiusParaFahrenheit)} °F");
            Console.WriteLine($"32 °F = {Aritmetica.ConverterTemperatura(32, Aritmetica.ConversaoTemperatura.FahrenheitParaCelsius)} °C");

            Console.ReadKey();
        }
    }
}
