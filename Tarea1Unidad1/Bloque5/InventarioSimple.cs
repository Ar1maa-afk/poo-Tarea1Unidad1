namespace Tarea1Unidad1.Bloque5
{
    public class InventarioSimple
    {
        public InventarioSimple()
        {
            int[,] inventario = new int[5, 3];

            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Código: ");
                int.TryParse(Console.ReadLine(), out inventario[i, 0]);

                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cantidad: ");
                int.TryParse(Console.ReadLine(), out inventario[i, 1]);

                Console.Write("Precio: ");
                int.TryParse(Console.ReadLine(), out inventario[i, 2]);
            }

            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Actualizar cantidad");
            Console.WriteLine("4. Valor total");

            int.TryParse(Console.ReadLine(), out int opcion);

            switch (opcion)
            {
                case 1:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(
                            inventario[i, 0] + " - " +
                            nombres[i] + " - " +
                            inventario[i, 1] + " - L." +
                            inventario[i, 2]);
                    }

                    break;

                case 2:

                    Console.Write("Código a buscar: ");
                    int.TryParse(Console.ReadLine(), out int codigo);

                    for (int i = 0; i < 5; i++)
                    {
                        if (inventario[i, 0] == codigo)
                        {
                            Console.WriteLine(
                                nombres[i] +
                                " Cantidad: " +
                                inventario[i, 1]);
                        }
                    }

                    break;

                case 3:

                    Console.Write("Código: ");
                    int.TryParse(Console.ReadLine(), out codigo);

                    for (int i = 0; i < 5; i++)
                    {
                        if (inventario[i, 0] == codigo)
                        {
                            Console.Write("Nueva cantidad: ");
                            int.TryParse(Console.ReadLine(),
                                out inventario[i, 1]);
                        }
                    }

                    break;

                case 4:

                    double total = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        total += inventario[i, 1] *
                                 inventario[i, 2];
                    }

                    Console.WriteLine("Valor total: L." + total);

                    break;
            }
        }
    }
}