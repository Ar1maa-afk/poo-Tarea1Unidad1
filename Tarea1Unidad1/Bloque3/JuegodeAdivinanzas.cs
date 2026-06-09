namespace Tarea1Unidad1.Bloque3
{
    public class JuegodeAdivinanzas
    {
        public JuegodeAdivinanzas()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int intentos = 0;
            bool adivino = false;

            Console.WriteLine("Adivina el número entre 1 y 100.");
            Console.WriteLine("Tienes 7 intentos.");

            while (intentos < 7 && !adivino)
            {
                Console.Write("Intento " + (intentos + 1) + ": ");

                int.TryParse(Console.ReadLine(), out int numero);

                intentos++;

                if (numero == numeroSecreto)
                {
                    adivino = true;
                    Console.WriteLine("¡Correcto!");
                }
                else if (numero < numeroSecreto)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else
                {
                    Console.WriteLine("El número es menor.");
                }
            }

            Console.WriteLine("\n--- Estadísticas ---");
            Console.WriteLine("Número secreto: " + numeroSecreto);
            Console.WriteLine("Intentos usados: " + intentos);

            if (adivino)
            {
                Console.WriteLine("Resultado: Ganó");
            }
            else
            {
                Console.WriteLine("Resultado: Perdió");
            }
        }
    }
}