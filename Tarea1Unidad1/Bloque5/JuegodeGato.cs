namespace Tarea1Unidad1.Bloque5
{
    public class JuegodeGato
    {
        public JuegodeGato()
        {
            bool reiniciar = true;

            while (reiniciar)
            {
                char[,] tablero =
                {
                    { '-', '-', '-' },
                    { '-', '-', '-' },
                    { '-', '-', '-' }
                };

                char jugador = 'X';
                bool ganador = false;
                int movimientos = 0;

                while (!ganador && movimientos < 9)
                {
                    Console.Clear();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(tablero[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Jugador " + jugador);

                    Console.Write("Fila (0-2): ");
                    int.TryParse(Console.ReadLine(), out int fila);

                    Console.Write("Columna (0-2): ");
                    int.TryParse(Console.ReadLine(), out int columna);

                    if (fila >= 0 && fila < 3 &&
                        columna >= 0 && columna < 3 &&
                        tablero[fila, columna] == '-')
                    {
                        tablero[fila, columna] = jugador;
                        movimientos++;

                        for (int i = 0; i < 3; i++)
                        {
                            if (tablero[i,0] == jugador &&
                                tablero[i,1] == jugador &&
                                tablero[i,2] == jugador)
                                ganador = true;

                            if (tablero[0,i] == jugador &&
                                tablero[1,i] == jugador &&
                                tablero[2,i] == jugador)
                                ganador = true;
                        }

                        if ((tablero[0,0] == jugador &&
                             tablero[1,1] == jugador &&
                             tablero[2,2] == jugador) ||

                            (tablero[0,2] == jugador &&
                             tablero[1,1] == jugador &&
                             tablero[2,0] == jugador))
                        {
                            ganador = true;
                        }

                        if (!ganador)
                        {
                            jugador = jugador == 'X' ? 'O' : 'X';
                        }
                    }
                }

                if (ganador)
                {
                    Console.WriteLine("Ganó el jugador " + jugador);
                }
                else
                {
                    Console.WriteLine("Empate");
                }

                Console.WriteLine("¿Reiniciar? 1=Sí 0=No");
                reiniciar = Console.ReadLine() == "1";
            }
        }
    }
}