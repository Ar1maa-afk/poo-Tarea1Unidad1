namespace Tarea1Unidad1.Bloque5
{
    public class MatrizdeNotasporParcial
    {
        public MatrizdeNotasporParcial(int estudiantes)
        {
            double[,] notas = new double[estudiantes, 3];

            for (int i = 0; i < estudiantes; i++)
            {
                Console.WriteLine("Estudiante " + (i + 1));

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Parcial " + (j + 1) + ": ");
                    double.TryParse(Console.ReadLine(), out notas[i, j]);
                }
            }

            double mejorPromedio = 0;
            int mejorEstudiante = 0;

            Console.WriteLine("\nPromedio por estudiante:");

            for (int i = 0; i < estudiantes; i++)
            {
                double suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }

                double promedio = suma / 3;

                Console.WriteLine("Estudiante " + (i + 1) + ": " + promedio);

                if (i == 0 || promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    mejorEstudiante = i + 1;
                }
            }

            double promedioMasBajo = 0;
            int parcialMasDificil = 0;

            Console.WriteLine("\nPromedio por parcial:");

            for (int j = 0; j < 3; j++)
            {
                double suma = 0;

                for (int i = 0; i < estudiantes; i++)
                {
                    suma += notas[i, j];
                }

                double promedio = suma / estudiantes;

                Console.WriteLine("Parcial " + (j + 1) + ": " + promedio);

                if (j == 0 || promedio < promedioMasBajo)
                {
                    promedioMasBajo = promedio;
                    parcialMasDificil = j + 1;
                }
            }

            Console.WriteLine("\nMejor estudiante: " + mejorEstudiante);
            Console.WriteLine("Parcial más difícil: " + parcialMasDificil);
        }
    }
}