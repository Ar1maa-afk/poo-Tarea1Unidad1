namespace Tarea1Unidad1.Bloque3
{
    public class ValidaciondeContrasenia
    {
        public ValidaciondeContrasenia()
        {
            bool valida = false;

            while (!valida)
            {
                Console.WriteLine("Ingrese una contraseña:");
                string contrasenia = Console.ReadLine();

                bool longitud = contrasenia.Length >= 8;
                bool mayuscula = false;
                bool minuscula = false;
                bool numero = false;
                bool especial = false;

                for (int i = 0; i < contrasenia.Length; i++)
                {
                    char c = contrasenia[i];

                    if (c >= 'A' && c <= 'Z')
                    {
                        mayuscula = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        minuscula = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        numero = true;
                    }
                    else
                    {
                        especial = true;
                    }
                }

                if (longitud && mayuscula && minuscula && numero && especial)
                {
                    valida = true;
                    Console.WriteLine("Contraseña válida.");
                }
                else
                {
                    Console.WriteLine("La contraseña no cumple los requisitos:");

                    if (!longitud)
                    {
                        Console.WriteLine("- Debe tener al menos 8 caracteres.");
                    }

                    if (!mayuscula)
                    {
                        Console.WriteLine("- Debe contener una letra mayúscula.");
                    }

                    if (!minuscula)
                    {
                        Console.WriteLine("- Debe contener una letra minúscula.");
                    }

                    if (!numero)
                    {
                        Console.WriteLine("- Debe contener un número.");
                    }

                    if (!especial)
                    {
                        Console.WriteLine("- Debe contener un carácter especial.");
                    }
                }
            }
        }
    }
}