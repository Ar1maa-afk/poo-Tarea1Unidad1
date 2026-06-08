namespace Tarea1Unidad1.Bloque2
{
    public class ValidadordeFecha
    {
        public ValidadordeFecha(int dia, int mes, int anio)
        {
            bool bisiesto = false;
            int diasMes = 0;

            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                bisiesto = true;
            }

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 ||
                mes == 8 || mes == 10 || mes == 12)
            {
                diasMes = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasMes = 30;
            }
            else if (mes == 2)
            {
                if (bisiesto)
                {
                    diasMes = 29;
                }
                else
                {
                    diasMes = 28;
                }
            }
            else
            {
                Console.WriteLine("Fecha inválida.");
                return;
            }

            if (dia >= 1 && dia <= diasMes)
            {
                Console.WriteLine("La fecha es válida.");
            }
            else
            {
                Console.WriteLine("La fecha es inválida.");
            }
        }
    }
}