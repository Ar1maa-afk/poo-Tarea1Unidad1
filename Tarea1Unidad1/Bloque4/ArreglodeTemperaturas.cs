namespace Tarea1Unidad1.Bloque4
{
    public class ArreglodeTemperaturas
    {
        public ArreglodeTemperaturas()
        {
            double[] temperaturas = new double[7];

            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Temperatura día " + (i + 1) + ": ");
                double.TryParse(Console.ReadLine(), out temperaturas[i]);

                suma += temperaturas[i];
            }

            double promedio = suma / 7;

            int diaCaluroso = 0;
            int diaFrio = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > temperaturas[diaCaluroso])
                {
                    diaCaluroso = i;
                }

                if (temperaturas[i] < temperaturas[diaFrio])
                {
                    diaFrio = i;
                }
            }

            int sobrePromedio = 0;

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    sobrePromedio++;
                }
            }

            Console.WriteLine("Promedio semanal: " + promedio);
            Console.WriteLine("Días sobre el promedio: " + sobrePromedio);
            Console.WriteLine("Día más caluroso: " + (diaCaluroso + 1));
            Console.WriteLine("Día más frío: " + (diaFrio + 1));

            Console.WriteLine("Variación entre días:");

            for (int i = 0; i < 6; i++)
            {
                double variacion = temperaturas[i + 1] - temperaturas[i];

                Console.WriteLine(
                    "Día " + (i + 1) +
                    " a Día " + (i + 2) +
                    ": " + variacion);
            }
        }
    }
}