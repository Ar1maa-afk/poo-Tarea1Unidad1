namespace Tarea1Unidad1.Bloque4
{
    public class FrecuenciadeElementos
    {
        public FrecuenciadeElementos()
        {
            Random random = new Random();

            int[] numeros = new int[20];
            int[] frecuencia = new int[11];

            Console.WriteLine("Números generados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 11);

                Console.Write(numeros[i] + " ");

                frecuencia[numeros[i]]++;
            }

            Console.WriteLine();

            int mayorFrecuencia = frecuencia[1];
            int menorFrecuencia = frecuencia[1];

            int numeroMayor = 1;
            int numeroMenor = 1;

            Console.WriteLine("\nFrecuencias:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ": " + frecuencia[i]);

                if (frecuencia[i] > mayorFrecuencia)
                {
                    mayorFrecuencia = frecuencia[i];
                    numeroMayor = i;
                }

                if (frecuencia[i] < menorFrecuencia)
                {
                    menorFrecuencia = frecuencia[i];
                    numeroMenor = i;
                }
            }

            Console.WriteLine("Más frecuente: " + numeroMayor);
            Console.WriteLine("Menos frecuente: " + numeroMenor);
        }
    }
}