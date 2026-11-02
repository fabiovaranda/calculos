namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas básicas
    /// </summary>
    internal static class Aritmetica
    {
  
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
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplica dois números inteiros e retorna o resultado
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>retorna a multiplicação de 2 números inteiros</returns>
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}