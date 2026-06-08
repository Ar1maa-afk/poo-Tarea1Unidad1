namespace Tarea1Unidad1.Bloque1
{
    public class CalculodeSalarioSemanal
    {
        public CalculodeSalarioSemanal(double horas, double tarifa)
        {
            double horasNormales;
            double horasExtras;
            double pagoNormal;
            double pagoExtra;
            double total;

            if (horas > 44)
            {
                horasNormales = 44;
                horasExtras = horas - 44;
            }
            else
            {
                horasNormales = horas;
                horasExtras = 0;
            }

            pagoNormal = horasNormales * tarifa;
            pagoExtra = horasExtras * tarifa * 1.5;
            total = pagoNormal + pagoExtra;

            Console.WriteLine("Horas normales: " + horasNormales);
            Console.WriteLine("Horas extras: " + horasExtras);
            Console.WriteLine("Pago normal: L. " + pagoNormal);
            Console.WriteLine("Pago extra: L. " + pagoExtra);
            Console.WriteLine("Total a pagar: L. " + total);
        }
    }
}