using hospital.Classes;
using hospital.Classes.People;
using System;
using System.Collections.Generic;
using System.Media;

namespace hospital
{
    public class RequestDataPerson
    {

        public static Doctor RequestDataDoctor()
        {
            string identification = Menu.RequestAString("Introduce la identificación del Doctor/a: "); ;
            string name =           Menu.RequestAString("Introduce el nombre del Doctor/a: "); ;
            string lastName =       Menu.RequestAString("Introduce el apellido del Doctor/a: "); ;
            int age =               Menu.RequestANumber("Introduce la edad del Doctor/a: ", 16, 75);

            Doctor doctor = new Doctor(identification, name, lastName, age);

            return doctor;
        }

        public static Patient RequestDataPatient(Hospital hospital)
        {
            string identification = Menu.RequestAString("Introduce la identificación del Doctor/a: "); ;
            string name =           Menu.RequestAString("Introduce el nombre del Doctor/a: "); ;
            string lastName =       Menu.RequestAString("Introduce el apellido del Doctor/a: "); ;
            int age =               Menu.RequestANumber("Introduce la edad del Doctor/a: ", 16, 75);

            Console.WriteLine(hospital.ListDoctors());
            Doctor doctorAssigned = 

            Patient doctor = new Patient(identification, name, lastName, age);

            return doctor;
        }

        public static Administrative RequestDataAdministrative()
        {
            string identification = Menu.RequestAString("Introduce la identificación del Doctor/a: "); ;
            string name =           Menu.RequestAString("Introduce el nombre del Doctor/a: "); ;
            string lastName =       Menu.RequestAString("Introduce el apellido del Doctor/a: "); ;
            int age =               Menu.RequestANumber("Introduce la edad del Doctor/a: ", 16, 75);

            Administrative admnistrative = new Administrative(identification, name, lastName, age);

            return admnistrative;
        }
    }
}
