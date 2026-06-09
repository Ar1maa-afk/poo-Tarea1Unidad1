namespace Tarea1Unidad1.Bloque3
{
    public class Calculadoraconmenu
    {
        public Calculadoraconmenu()
        {
            double resultado = 0;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nResultado actual: " + resultado);
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Salir");

                Console.Write("Seleccione una opción: ");
                int.TryParse(Console.ReadLine(), out int opcion);

                double numero;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Número: ");
                        double.TryParse(Console.ReadLine(), out numero);
                        resultado += numero;
                        break;

                    case 2:
                        Console.Write("Número: ");
                        double.TryParse(Console.ReadLine(), out numero);
                        resultado -= numero;
                        break;

                    case 3:
                        Console.Write("Número: ");
                        double.TryParse(Console.ReadLine(), out numero);
                        resultado *= numero;
                        break;

                    case 4:
                        Console.Write("Número: ");
                        double.TryParse(Console.ReadLine(), out numero);

                        if (numero != 0)
                        {
                            resultado /= numero;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        break;

                    case 5:
                        Console.Write("Exponente: ");
                        double.TryParse(Console.ReadLine(), out numero);

                        resultado = Math.Pow(resultado, numero);
                        break;

                    case 6:
                        if (resultado >= 0)
                        {
                            resultado = Math.Sqrt(resultado);
                        }
                        else
                        {
                            Console.WriteLine("No existe raíz cuadrada real.");
                        }
                        break;

                    case 7:
                        Console.Write("Porcentaje: ");
                        double.TryParse(Console.ReadLine(), out numero);

                        resultado = resultado * numero / 100;
                        break;

                    case 8:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }

            Console.WriteLine("Resultado final: " + resultado);
        }
    }
}