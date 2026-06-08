namespace Tarea1Unidad1.Bloque2
{
    public class CalculadoradeDescuentos
    {
        public CalculadoradeDescuentos(decimal monto)
        {
            decimal descuento = 0;
            decimal porcentaje = 0;
            decimal precioFinal;

            if (monto >= 2500)
            {
                porcentaje = 15;
            }
            else if (monto >= 1000)
            {
                porcentaje = 10;
            }
            else if (monto >= 500)
            {
                porcentaje = 5;
            }

            descuento = monto * porcentaje / 100;
            precioFinal = monto - descuento;

            Console.WriteLine("Precio original: L. " + monto);
            Console.WriteLine("Descuento aplicado: " + porcentaje + "%");
            Console.WriteLine("Monto descontado: L. " + descuento);
            Console.WriteLine("Precio final: L. " + precioFinal);
        }
    }
}