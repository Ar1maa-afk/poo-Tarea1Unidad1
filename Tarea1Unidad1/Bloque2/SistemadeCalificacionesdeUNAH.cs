namespace Tarea1Unidad1.Bloque2    
{
public class SistemadeCalificacionesdeUNAH
    {
        public SistemadeCalificacionesdeUNAH(double nota)
        {
            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("La nota ingresada no es válida.");
            }
            else if (nota >= 90)
            {
                Console.WriteLine("Letra: A");
                Console.WriteLine("Descripción: Excelente");
                Console.WriteLine("Estado: Aprobó");
            }
            else if (nota >= 80)
            {
                Console.WriteLine("Letra: B");
                Console.WriteLine("Descripción: Muy Bueno");
                Console.WriteLine("Estado: Aprobó");
            }
            else if (nota >= 70)
            {
                Console.WriteLine("Letra: C");
                Console.WriteLine("Descripción: Bueno");
                Console.WriteLine("Estado: Aprobó");
            }
            else if (nota >= 60)
            {
                Console.WriteLine("Letra: D");
                Console.WriteLine("Descripción: Suficiente");
                Console.WriteLine("Estado: Aprobó");
            }
            else
            {
                Console.WriteLine("Letra: F");
                Console.WriteLine("Descripción: Reprobado");
                Console.WriteLine("Estado: Reprobó");
            }
        }
    }
}