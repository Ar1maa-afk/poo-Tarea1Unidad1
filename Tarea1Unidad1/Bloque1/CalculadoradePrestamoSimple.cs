namespace Tarea1Unidad1.Bloque1
{
    public class CalculadoradePrestamoSimple
    {
        public CalculadoradePrestamoSimple(decimal monto, decimal tasaAnual, int meses)
        {
            decimal tasaDecimal = tasaAnual / 100;
            decimal tiempoAnios = meses / 12m;

            decimal interesTotal = monto * tasaDecimal * tiempoAnios;
            decimal totalPagar = monto + interesTotal;
            decimal cuotaMensual = totalPagar / meses;

            Console.WriteLine($"\nMonto prestado: L. {monto:F2}");
            Console.WriteLine($"Interés total: L. {interesTotal:F2}");
            Console.WriteLine($"Total a pagar: L. {totalPagar:F2}");
            Console.WriteLine($"Cuota mensual: L. {cuotaMensual:F2}");
        }
    }
}