namespace Tarea1Unidad1.Bloque4
{
    public class EstadisticasdeCalificaciones
    {
        public EstadisticasdeCalificaciones(int cantidad)
        {
            double[] notas = new double[cantidad];

            double suma = 0;
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                double.TryParse(Console.ReadLine(), out notas[i]);

                suma += notas[i];

                if (notas[i] >= 65)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double maxima = notas[0];
            double minima = notas[0];

            for (int i = 1; i < cantidad; i++)
            {
                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }

                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }

            double promedio = suma / cantidad;

            double sumaCuadrados = 0;

            for (int i = 0; i < cantidad; i++)
            {
                sumaCuadrados += Math.Pow(notas[i] - promedio, 2);
            }

            double desviacion = Math.Sqrt(sumaCuadrados / cantidad);

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Máxima: " + maxima);
            Console.WriteLine("Mínima: " + minima);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);
            Console.WriteLine("Desviación estándar: " + desviacion);
        }
    }
}