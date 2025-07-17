using System;


namespace ArraysListas
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers) // recebe um vetor de numeros como parametro
        {
            int sum = 0;
            for (int i = 0; i< numbers.Length; i++) // usamos o lenght para saber o tamnho do vetor
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void triple(ref int x) // O modificador ref permite passar uma variável por referência, permitindo que o método modifique seu valor original
        {
            x *= 3;
        }
    
        public static void dobro(int origin, out int result) // O modificador out permite que o método retorne um valor adicional, além do valor de retorno principal
        {
            result = origin * 2; // O modificador out permite que o método retorne um valor adicional, além do valor de retorno principal
        }
    
    }
}
