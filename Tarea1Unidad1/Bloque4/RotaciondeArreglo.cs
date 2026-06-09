namespace Tarea1Unidad1.Bloque4
{
    public class RotaciondeArreglo
    {
        public RotaciondeArreglo(int n)
        {
            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemento " + (i + 1) + ": ");
                int.TryParse(Console.ReadLine(), out arreglo[i]);
            }

            Console.WriteLine("1. Rotar izquierda");
            Console.WriteLine("2. Rotar derecha");
            Console.WriteLine("3. Invertir");

            int.TryParse(Console.ReadLine(), out int opcion);

            if (opcion == 1)
            {
                Console.Write("K: ");
                int.TryParse(Console.ReadLine(), out int k);

                for (int r = 0; r < k; r++)
                {
                    int primero = arreglo[0];

                    for (int i = 0; i < n - 1; i++)
                    {
                        arreglo[i] = arreglo[i + 1];
                    }

                    arreglo[n - 1] = primero;
                }
            }
            else if (opcion == 2)
            {
                Console.Write("K: ");
                int.TryParse(Console.ReadLine(), out int k);

                for (int r = 0; r < k; r++)
                {
                    int ultimo = arreglo[n - 1];

                    for (int i = n - 1; i > 0; i--)
                    {
                        arreglo[i] = arreglo[i - 1];
                    }

                    arreglo[0] = ultimo;
                }
            }
            else if (opcion == 3)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int aux = arreglo[i];
                    arreglo[i] = arreglo[n - 1 - i];
                    arreglo[n - 1 - i] = aux;
                }
            }

            Console.WriteLine("Resultado:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
        }
    }
}