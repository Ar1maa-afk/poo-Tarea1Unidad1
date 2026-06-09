namespace Tarea1Unidad1.Bloque3
{
    public class FactorialyCombinaciones
    {
        public FactorialyCombinaciones(int n, int r)
        {
            long factorialN = 1;
            long factorialR = 1;
            long factorialNR = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            for (int i = 1; i <= r; i++)
            {
                factorialR *= i;
            }

            for (int i = 1; i <= (n - r); i++)
            {
                factorialNR *= i;
            }

            long combinacion = factorialN / (factorialR * factorialNR);

            Console.WriteLine(n + "! = " + factorialN);
            Console.WriteLine(r + "! = " + factorialR);
            Console.WriteLine((n - r) + "! = " + factorialNR);
            Console.WriteLine("C(" + n + "," + r + ") = " + combinacion);
        }
    }
}