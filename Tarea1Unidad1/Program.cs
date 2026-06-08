using Tarea1Unidad1.Bloque1;

namespace Tarea1Unidad1
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while(!salir)
            {
                Console.Clear();
                Console.WriteLine("Ejercicios de Tarea");
                Console.WriteLine("1. Calculadora de IMC");
                Console.WriteLine("2. Conversion de Temperatura");
                Console.WriteLine("3. Desglose de billetes");
                Console.WriteLine("4. Calculadora de préstamo simple");
                Console.WriteLine("5. Tiempo transcurrido");
                Console.WriteLine("6. Área y perímetro");
                Console.WriteLine("7. Conversión de unidades de almacenamiento");
                Console.WriteLine("8. Cálculo de salario semanal");
                Console.WriteLine("9. Clasificación de triángulos");
                Console.WriteLine("10. Sistema de calificaciones UNAH");
                Console.WriteLine("11. Calculadora de descuentos");
                Console.WriteLine("12. Año bisiesto y días del mes");
                Console.WriteLine("13. Validador de fecha");
                Console.WriteLine("14. Cajero automático");
                Console.WriteLine("15. Tabla de multiplicar extendida");
                Console.WriteLine("16. Números primos en rango");
                Console.WriteLine("17. Serie Fibonacci");
                Console.WriteLine("18. Factorial y combinaciones");
                Console.WriteLine("19. Juego de adivinanza");
                Console.WriteLine("20. Validación de contraseña");
                Console.WriteLine("21. Patrón de asteriscos");
                Console.WriteLine("22. Calculadora con menú");
                Console.WriteLine("23. Estadísticas de calificaciones");
                Console.WriteLine("24. Búsqueda y ordenamiento");
                Console.WriteLine("25. Rotación de arreglo");
                Console.WriteLine("26. Frecuencia de elementos");
                Console.WriteLine("27. Arreglo de temperaturas");
                Console.WriteLine("28. Matriz de notas por parcial");
                Console.WriteLine("29. Juego de Gato (Tic-Tac-Toe)");
                Console.WriteLine("30. Inventario simple");
                Console.WriteLine("Ingrese ejercicio:"); // Un menu para que logre saber cual es cada ejercicio y su numero correspondiente.
                int.TryParse(Console.ReadLine(), out int Go);
                int Ejercicio = Go;
                switch (Ejercicio)
                {
                    case 1:
                        Console.WriteLine("Ingrese su peso en kg:");
                        decimal.TryParse(Console.ReadLine(), out decimal n1);
                        Console.WriteLine("Ingrese su altura:");
                        decimal.TryParse(Console.ReadLine(), out decimal n2); // Aqui leemos cada uno de los argumento que debe recibir el primer ejercicio.
                        CalculadoradeIMC calculadoradeIMC = new CalculadoradeIMC(n1, n2); //Mandamos a llamar el metodo de constructor.
                        break;
                    case 2:
                        Console.WriteLine("Convertir temperatura");
                        Console.WriteLine("1. Celsius a Fahrenheit");
                        Console.WriteLine("2. Celsius a Kelvin");
                        Console.WriteLine("3. Fahrenheit a Celsius");
                        Console.WriteLine("4. Fahrenheit a Kelvin");
                        Console.WriteLine("5. Kelvin a Celsius");
                        Console.WriteLine("6. Kelvin a Fahrenheit");
                        Console.Write("Seleccione una opción: ");

                        if (!int.TryParse(Console.ReadLine(), out int opcionTemp))
                        {
                            Console.WriteLine("Opción inválida.");
                            break;
                        }

                        Console.Write("Ingrese la temperatura: ");

                        if (!double.TryParse(Console.ReadLine(), out double temperatura))
                        {
                            Console.WriteLine("Temperatura inválida.");
                            break;
                        }

                        ConversiondeTemperatura conversiondeTemperatura = new ConversiondeTemperatura(opcionTemp, temperatura);

                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto en lempiras:");

                        if (int.TryParse(Console.ReadLine(), out int monto) && monto > 0)
                        {
                            DesgloseBilletes desgloseBilletes = new DesgloseBilletes(monto);
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el monto del préstamo:");

                        if (!decimal.TryParse(Console.ReadLine(), out decimal montos))
                        {
                            Console.WriteLine("Monto inválido.");
                            break;
                        }

                        Console.WriteLine("Ingrese la tasa de interés anual (%):");

                        if (!decimal.TryParse(Console.ReadLine(), out decimal tasa))
                        {
                            Console.WriteLine("Tasa inválida.");
                            break;
                        }

                        Console.WriteLine("Ingrese el plazo en meses:");

                        if (!int.TryParse(Console.ReadLine(), out int meses))
                        {
                            Console.WriteLine("Plazo inválido.");
                            break;
                        }

                        CalculadoradePrestamoSimple calculadoradePrestamoSimple = new CalculadoradePrestamoSimple(montos, tasa, meses);
                        break;
                    case 5:
                        Console.WriteLine("Primera hora");

                        Console.Write("Hora: ");
                        int.TryParse(Console.ReadLine(), out int h1);

                        Console.Write("Minuto: ");
                        int.TryParse(Console.ReadLine(), out int m1);

                        Console.Write("Segundo: ");
                        int.TryParse(Console.ReadLine(), out int s1);

                        Console.WriteLine("\nSegunda hora");

                        Console.Write("Hora: ");
                        int.TryParse(Console.ReadLine(), out int h2);

                        Console.Write("Minuto: ");
                        int.TryParse(Console.ReadLine(), out int m2);

                        Console.Write("Segundo: ");
                        int.TryParse(Console.ReadLine(), out int s2);

                        TiempoTranscurrido tiempoTranscurrido = new TiempoTranscurrido(h1, m1, s1, h2, m2, s2);

                        break;
                    case 6:
                        Console.WriteLine("Figuras");
                        Console.WriteLine("1. Círculo");
                        Console.WriteLine("2. Triángulo");
                        Console.WriteLine("3. Rectángulo");
                        Console.WriteLine("4. Trapecio");

                        if (!int.TryParse(Console.ReadLine(), out int opcionFigura))
                        {
                            Console.WriteLine("Opción inválida.");
                            break;
                        }

                        AreayPerimetro areayPerimetro = new AreayPerimetro(opcionFigura);
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    case 8:
                        Console.WriteLine("Dia no valido");
                        break;
                }
                Console.WriteLine("\nPresione ENTER para volver al menú...");
                Console.WriteLine("O escriba 0 para salir:");

                string opcion = Console.ReadLine(); // verifica que el usuario escriba 0, nada mas.

                if (opcion == "0")
                {
                    salir = true;
                }
            }
        }
    }   
}