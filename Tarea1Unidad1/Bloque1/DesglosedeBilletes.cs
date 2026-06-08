namespace Tarea1Unidad1.Bloque1
{
    public class DesgloseBilletes
    {
        public DesgloseBilletes(int monto)
        {
            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine($"\nDesglose de L. {monto}");

            foreach (int billete in billetes)
            {
                int cantidad = monto / billete;

                if (cantidad > 0)
                {
                    Console.WriteLine($"{cantidad} billete(s) de L. {billete}");
                    monto %= billete;
                }
            }
        }
    }
}