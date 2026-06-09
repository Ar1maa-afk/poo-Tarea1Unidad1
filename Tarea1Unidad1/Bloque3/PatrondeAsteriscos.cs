namespace Tarea1Unidad1.Bloque3
{
    public class PatrondeAsteriscos
    {
        public PatrondeAsteriscos(int opcion, int tamanio)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Triángulo");

                    for (int i = 1; i <= tamanio; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("Triángulo invertido");

                    for (int i = tamanio; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("Rombo");

                    for (int i = 1; i <= tamanio; i++)
                    {
                        for (int j = i; j < tamanio; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    for (int i = tamanio - 1; i >= 1; i--)
                    {
                        for (int j = tamanio; j > i; j--)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 1; j <= (2 * i - 1); j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.WriteLine("Cuadrado hueco");

                    for (int i = 1; i <= tamanio; i++)
                    {
                        for (int j = 1; j <= tamanio; j++)
                        {
                            if (i == 1 || i == tamanio || j == 1 || j == tamanio)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}