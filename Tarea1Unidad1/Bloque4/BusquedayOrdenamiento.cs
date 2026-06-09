namespace Tarea1Unidad1.Bloque4
{
    public class BusquedayOrdenamiento
    {
        public BusquedayOrdenamiento()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int.TryParse(Console.ReadLine(), out numeros[i]);
            }

            Console.Write("Número a buscar: ");
            int.TryParse(Console.ReadLine(), out int buscado);

            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    Console.WriteLine("Encontrado en posición " + i);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No encontrado.");
            }

            int mayor = numeros[0];
            int segundoMayor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    segundoMayor = mayor;
                    mayor = numeros[i];
                }
                else if (numeros[i] > segundoMayor &&
                         numeros[i] != mayor)
                {
                    segundoMayor = numeros[i];
                }
            }

            Console.WriteLine("Segundo mayor: " + segundoMayor);

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Orden ascendente:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Posiciones pares:");

            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine();
        }
    }
}