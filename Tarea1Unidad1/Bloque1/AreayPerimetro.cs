namespace Tarea1Unidad1.Bloque1
{
    public class AreayPerimetro
    {
        public AreayPerimetro(int opcion)
        {
            double area, perimetro;

            switch (opcion)
            {
                case 1:
                    Console.Write("Radio: ");
                    if (!double.TryParse(Console.ReadLine(), out double radio) || radio <= 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        return;
                    }

                    area = Math.PI * radio * radio;
                    perimetro = 2 * Math.PI * radio;

                    Console.WriteLine($"Área: {area:F2}");
                    Console.WriteLine($"Perímetro: {perimetro:F2}");
                    break;

                case 2:
                    Console.Write("Base: ");
                    double.TryParse(Console.ReadLine(), out double baseTri);

                    Console.Write("Lado 2: ");
                    double.TryParse(Console.ReadLine(), out double l2);

                    Console.Write("Lado 3: ");
                    double.TryParse(Console.ReadLine(), out double l3);

                    if (baseTri <= 0 || l2 <= 0 || l3 <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    if (baseTri + l2 <= l3 ||
                        baseTri + l3 <= l2 ||
                        l2 + l3 <= baseTri)
                    {
                        Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
                        return;
                    }

                    // Área con fórmula de Herón
                    double s = (baseTri + l2 + l3) / 2;
                    area = Math.Sqrt(s * (s - baseTri) * (s - l2) * (s - l3));

                    // Altura correspondiente a la base
                    double altura = (2 * area) / baseTri;

                    perimetro = baseTri + l2 + l3;

                    Console.WriteLine($"Altura: {altura:F2}");
                    Console.WriteLine($"Área: {area:F2}");
                    Console.WriteLine($"Perímetro: {perimetro:F2}");
                    break;
                case 3:
                    Console.Write("Base: ");
                    double.TryParse(Console.ReadLine(), out double baseRect);

                    Console.Write("Altura: ");
                    double.TryParse(Console.ReadLine(), out double alturaRect);

                    if (baseRect <= 0 || alturaRect <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    area = baseRect * alturaRect;
                    perimetro = 2 * (baseRect + alturaRect);

                    Console.WriteLine($"Área: {area:F2}");
                    Console.WriteLine($"Perímetro: {perimetro:F2}");
                    break;

                case 4:
                    Console.Write("Base mayor: ");
                    double.TryParse(Console.ReadLine(), out double B);

                    Console.Write("Base menor: ");
                    double.TryParse(Console.ReadLine(), out double b);

                    Console.Write("Altura: ");
                    double.TryParse(Console.ReadLine(), out double h);

                    Console.Write("Lado izquierdo: ");
                    double.TryParse(Console.ReadLine(), out double lado1);

                    Console.Write("Lado derecho: ");
                    double.TryParse(Console.ReadLine(), out double lado2);

                    if (B <= 0 || b <= 0 || h <= 0 || lado1 <= 0 || lado2 <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    area = ((B + b) * h) / 2;
                    perimetro = B + b + lado1 + lado2;

                    Console.WriteLine($"Área: {area:F2}");
                    Console.WriteLine($"Perímetro: {perimetro:F2}");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}