namespace Tarea1Unidad1.Bloque3
{
    public class SerieFibonacci
    {
        public SerieFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int siguiente;
            int suma = 0;

            Console.WriteLine("Serie Fibonacci:");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);

                suma += a;

                siguiente = a + b;
                a = b;
                b = siguiente;
            }

            double promedio = (double)suma / n;

            Console.WriteLine("Suma total: " + suma);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}