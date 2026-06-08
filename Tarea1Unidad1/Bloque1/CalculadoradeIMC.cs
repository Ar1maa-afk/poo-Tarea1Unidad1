namespace Tarea1Unidad1.Bloque1
{
    public class CalculadoradeIMC
    {
        public CalculadoradeIMC(decimal peso, decimal altura)
        {
            decimal IMC = peso / (altura * altura); // La forma en que se calcula el IMC.

            if (IMC < 18.5m)
            {
                Console.WriteLine($"Su IMC es: {IMC:F2}. Usted está bajo de peso."); // El F2 es para que aparezca dos decimales despues del punto.
            }
            else if (IMC <= 24.9m)
            {
                Console.WriteLine($"Su IMC es: {IMC:F2}. Usted está en un peso normal.");
            }
            else if (IMC <= 29.9m)
            {
                Console.WriteLine($"Su IMC es: {IMC:F2}. Usted está en sobrepeso.");
            }
            else    
            {
                Console.WriteLine($"Su IMC es: {IMC:F2}. Usted está en obesidad.");
            }
        }
    }
}