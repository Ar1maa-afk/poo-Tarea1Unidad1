namespace Tarea1Unidad1.Bloque3
{
    public class NumerosPrimosenRango
    {
        public NumerosPrimosenRango(int inicio, int fin)
        {
            int contador = 0;

            Console.WriteLine("Números primos:");

            for (int numero = inicio; numero <= fin; numero++)
            {
                int divisores = 0;

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores++;
                    }
                }

                if (divisores == 2)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
            }

            Console.WriteLine("Cantidad de números primos: " + contador);
        }
    }
}