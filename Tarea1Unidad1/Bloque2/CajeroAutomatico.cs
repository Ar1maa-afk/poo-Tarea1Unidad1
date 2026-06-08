namespace Tarea1Unidad1.Bloque2
{
    public class CajeroAutomatico
    {
        public CajeroAutomatico(int retiro)
        {
            int saldo = 10000;

            if (retiro <= 0)
            {
                Console.WriteLine("Monto inválido.");
            }
            else if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else if (retiro % 20 != 0)
            {
                Console.WriteLine("El monto debe ser múltiplo de 20.");
            }
            else
            {
                saldo -= retiro;

                int b1000 = retiro / 1000;
                retiro %= 1000;

                int b500 = retiro / 500;
                retiro %= 500;

                int b100 = retiro / 100;
                retiro %= 100;

                int b50 = retiro / 50;
                retiro %= 50;

                int b20 = retiro / 20;

                Console.WriteLine("Retiro exitoso.");
                Console.WriteLine("Billetes entregados:");
                Console.WriteLine("L1000: " + b1000);
                Console.WriteLine("L500: " + b500);
                Console.WriteLine("L100: " + b100);
                Console.WriteLine("L50: " + b50);
                Console.WriteLine("L20: " + b20);
                Console.WriteLine("Saldo restante: L. " + saldo);
            }
        }
    }
}