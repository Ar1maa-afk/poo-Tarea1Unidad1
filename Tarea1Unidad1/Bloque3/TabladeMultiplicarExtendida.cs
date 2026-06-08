namespace Tarea1Unidad1.Bloque3
{
    public class TabladeMultiplicarExtendida
    {
        public TabladeMultiplicarExtendida(int numero)
        {
            Console.WriteLine("Tabla de multiplicar del " + numero);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{numero,3} x {i,2} = {(numero * i),4}");
            }
        }
    }
}