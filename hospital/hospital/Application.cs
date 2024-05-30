using hospital.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace hospital
{
    public class Application
    {

        //- Dar de alta un medico
        //- Dar de alta un paciente, para un médico concreto
        //- Dar de alta personal administrativo.
        //- Listar los médicos.
        //- Listar los pacientes de un medico.
        //- Eliminar a un paciente.
        //- Ver la lista de personas del hospital.

        public void HospitalAplication()
        {
            HospitalMenu();
        }

        public int HospitalMenu()
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

        public int RequestANumber(int minNumber, int maxNumber)
        {
            bool validNumber;
            int number;

            while(true) 
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

        public void DeleteAPatient(Classes.Application hospital)
        {
            Console.WriteLine(hospital.ListPatients());
        }

        public void RegisterADoctor()
        {

        }

        public void RegisterAPatient()
        {

        }

        public void RegisterAdministrative()
        {

        }
    }
}
