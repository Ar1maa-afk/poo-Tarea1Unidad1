namespace Tarea1Unidad1.Bloque1
{
    public class ConversiondeTemperatura
    {
        public ConversiondeTemperatura(int opcion, double temperatura)
        {
            double resultado;

            switch (opcion)
            {
                case 1:
                    resultado = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"{temperatura} °C = {resultado:F2} °F");
                    break;

                case 2:
                    resultado = temperatura + 273.15;
                    Console.WriteLine($"{temperatura} °C = {resultado:F2} K");
                    break;

                case 3:
                    resultado = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura} °F = {resultado:F2} °C");
                    break;

                case 4:
                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{temperatura} °F = {resultado:F2} K");
                    break;

                case 5:
                    resultado = temperatura - 273.15;
                    Console.WriteLine($"{temperatura} K = {resultado:F2} °C");
                    break;

                case 6:
                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"{temperatura} K = {resultado:F2} °F");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}