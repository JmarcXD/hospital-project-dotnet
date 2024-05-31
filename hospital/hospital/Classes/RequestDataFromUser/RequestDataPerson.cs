using hospital.Classes;
using System;

namespace hospital
{
    public class RequestDataPerson
    {

        public static Doctor RequestDataDoctor()
        {
            string identification = Menu.RequestAString("Introduce la identificación del Doctor/a: "); ;
            string name = Menu.RequestAString("Introduce el nombre del Doctor/a: "); ;
            string lastName = Menu.RequestAString("Introduce el apellido del Doctor/a: "); ;
            int age = Menu.RequestANumber("Introduce la edad del Doctor/a: ", 16, 75);

            Doctor doctor = new Doctor(identification, name, lastName, age);

            return doctor;
        }

        public static Patient RequestDataPatient(Doctor doctorAssigned)
        {
            string identification = Menu.RequestAString("Introduce la identificación del Paciente: ");
            string name = Menu.RequestAString("Introduce el nombre del Paciente: ");
            string lastName = Menu.RequestAString("Introduce el apellido del Paciente: ");
            int age = Menu.RequestANumber("Introduce la edad del Paciente: ", 16, 75);
 

            Patient doctor = new Patient(doctorAssigned, identification, name, lastName, age);

            return doctor;
        }

        public static Administrative RequestDataAdministrative()
        {
            string identification = Menu.RequestAString("Introduce la identificación del Personal Administrativo: "); ;
            string name = Menu.RequestAString("Introduce el nombre del Personal Administrativo: "); ;
            string lastName = Menu.RequestAString("Introduce el apellido del Personal Administrativo: "); ;
            int age = Menu.RequestANumber("Introduce la edad del Personal Administrativo: ", 16, 75);

            Administrative admnistrative = new Administrative(identification, name, lastName, age);

            return admnistrative;
        }

        public static Doctor RequestDoctorIdentificationAndGet(Hospital hospital)
        {
            Doctor doctor;

            Console.WriteLine(hospital.GetListDoctors());
            do
            {
                doctor = hospital.GetADoctorByIdentification(Menu.RequestAString("Introduce la identificación del Doctor/a que desea asignar: "));

                if (doctor == null)
                    Console.Write("\nDoctor no existe (Mira bien la lista).\n");

            } while (doctor == null);

            return doctor;
        }

        public static Patient RequestPatientIdentificationAndGet(Hospital hospital)
        {
            Patient patient;

            Console.WriteLine(hospital.GetListPatients());
            do
            {
                patient = hospital.GetAPatientByIdentification(Menu.RequestAString("Introduce la identificación del paciente que desea asignar: "));

                if (patient == null)
                    Console.Write("\nDoctor no existe (Mira bien la lista).\n");

            } while (patient == null);

            return patient;
        }
    }
}
