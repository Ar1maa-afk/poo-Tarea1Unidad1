namespace Tarea1Unidad1.Bloque1
{
    public class ConversionUnidadesAlmacenamiento
    {
        public ConversionUnidadesAlmacenamiento(int origen, int destino, double valor)
        {
            double bytes = valor;

            switch (origen)
            {
                case 2:
                    bytes = valor * 1024;
                    break;
                case 3:
                    bytes = valor * 1024 * 1024;
                    break;
                case 4:
                    bytes = valor * 1024 * 1024 * 1024;
                    break;
                case 5:
                    bytes = valor * 1024 * 1024 * 1024 * 1024;
                    break;
            }

            double resultado = bytes;

            switch(destino)
            {
                case 2:
                    resultado = bytes / 1024;
                    break;
                case 3:
                    resultado = bytes / (1024 * 1024);
                    break;
                case 4:
                    resultado = bytes / (1024 * 1024 * 1024);
                    break;
                case 5:
                    resultado = bytes / (1024d * 1024 * 1024 * 1024);
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}