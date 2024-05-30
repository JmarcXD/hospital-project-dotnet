using System;

namespace hospital
{
    public class Menu
    {
        public static int HospitalMenu()
        {
            Console.Write(@"
(1) Dar de alta un médico
(2) Dar de alta un paciente y asignar a un médico concreto
(3) Listar los médicos
(4) Listar los pacientes de un médico
(5) Eliminar a un paciente
(6) Mostrar la lista de personas del hospital
(0) Salir del programa
Introduzca el numero: ");
            int optionNumber = RequestANumber(1, 6);

            return optionNumber;
        }

        public static int RequestANumber(int minNumber, int maxNumber)
        {
            bool validNumber;
            int number;

            while (true)
            {
                validNumber = int.TryParse(Console.ReadLine(), out number);

                if (!validNumber)
                    Console.Write("Introduce un numero!!! Introduce el numero: ");
                else if (number > maxNumber || number < minNumber)
                    Console.Write($"Introduce un numero entre {minNumber} - {maxNumber}!! Introduce el numero: ");
                else
                    return number;
            }
        }

        public static int RequestANumber(string sentence, int minNumber, int maxNumber)
        {
            Console.Write(sentence);
            bool validNumber;
            int number;

            while (true)
            {
                validNumber = int.TryParse(Console.ReadLine(), out number);

                if (!validNumber)
                    Console.Write("Introduce un numero!!! Introduce el numero: ");
                else if (number > maxNumber || number < minNumber)
                    Console.Write($"Introduce un numero entre {minNumber} - {maxNumber}!! Introduce el numero: ");
                else
                    return number;
            }
        }

        public static string RequestAString(string sentence)
        {
            Console.Write(sentence);
            string text = Console.ReadLine();

            return text;
        }
    }
}
