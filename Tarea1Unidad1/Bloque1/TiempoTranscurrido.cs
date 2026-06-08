namespace Tarea1Unidad1.Bloque1
{
    public class TiempoTranscurrido
    {
        public TiempoTranscurrido(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            int total1 = h1 * 3600 + m1 * 60 + s1;
            int total2 = h2 * 3600 + m2 * 60 + s2;

            int diferencia;

            if (total2 < total1)
            {
                diferencia = (24 * 3600 - total1) + total2;
            }
            else
            {
                diferencia = total2 - total1;
            }

            int horas = diferencia / 3600;
            int minutos = (diferencia % 3600) / 60;
            int segundos = diferencia % 60;

            Console.WriteLine($"Diferencia: {horas} horas, {minutos} minutos y {segundos} segundos");
        }
    }
}