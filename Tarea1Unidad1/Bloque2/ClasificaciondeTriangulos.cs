namespace Tarea1Unidad1.Bloque2
{
    public class ClasificaciondeTriangulos
    {
        public ClasificaciondeTriangulos(double lado1, double lado2, double lado3)
        {
            if (lado1 + lado2 <= lado3 ||
                lado1 + lado3 <= lado2 ||
                lado2 + lado3 <= lado1)
            {
                Console.WriteLine("No forman un triángulo válido.");
            }
            else
            {
                Console.WriteLine("Triángulo válido.");

                // Clasificación por lados
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Isósceles");
                }
                else
                {
                    Console.WriteLine("Escaleno");
                }

                // Ordenar para que lado3 sea el mayor
                double temp;

                if (lado1 > lado2)
                {
                    temp = lado1;
                    lado1 = lado2;
                    lado2 = temp;
                }

                if (lado2 > lado3)
                {
                    temp = lado2;
                    lado2 = lado3;
                    lado3 = temp;
                }

                if (lado1 > lado2)
                {
                    temp = lado1;
                    lado1 = lado2;
                    lado2 = temp;
                }

                double a2 = lado1 * lado1;
                double b2 = lado2 * lado2;
                double c2 = lado3 * lado3;

                // Clasificación por ángulos
                if (a2 + b2 == c2)
                {
                    Console.WriteLine("Rectángulo");
                }
                else if (a2 + b2 > c2)
                {
                    Console.WriteLine("Acutángulo");
                }
                else
                {
                    Console.WriteLine("Obtusángulo");
                }
            }
        }
    }
}