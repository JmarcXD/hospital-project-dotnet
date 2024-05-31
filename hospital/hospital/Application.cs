using hospital.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hospital
{
    public class Application
    {
        private Hospital hospital { get; set; }

        public Application()
        {
            this.hospital = new Hospital("Hospital Sant Fundació Esplai");
        }

        public void HospitalAplication()
        {
            while (true)
            {
                int option = Menu.RequestOptionOfMenu();

                switch ((eMenuOptions)option)
                {
                    case eMenuOptions.RegisterDoctor:

                        Doctor newDoctor = RequestDataPerson.RequestDataDoctor();

                        hospital.RegisterADoctor(newDoctor);

                        break;
                    case eMenuOptions.RegisterAPatient:

                        Doctor doctorAssigned = RequestDataPerson.RequestDoctorIdentificationAndGet(hospital);
                        Patient newPatient = RequestDataPerson.RequestDataPatient(doctorAssigned);

                        hospital.RegisterAPatient(newPatient);

                        break;
                    case eMenuOptions.RegisterAAdministrative:

                        Administrative newAdministrative = RequestDataPerson.RequestDataAdministrative();

                        hospital.RegisterAAdministrative(newAdministrative);

                        break;
                    case eMenuOptions.ShowListDoctor:

                        Console.WriteLine(hospital.GetListDoctors());

                        break;
                    case eMenuOptions.ShowListDoctorPatients:

                        Doctor doctor = RequestDataPerson.RequestDoctorIdentificationAndGet(hospital);
                        Console.WriteLine(doctor.GetListOwnPatients());

                        break;
                    case eMenuOptions.DeleteAPatient:

                        Patient patientToDelete = RequestDataPerson.RequestPatientIdentificationAndGet(hospital);
                        hospital.DeleteAPatientByObject(patientToDelete);

                        break;
                    case eMenuOptions.ShowListHospitalPersons:

                        Console.WriteLine(hospital.GetListPersons());

                        break;
                    default:
                        return;
                }

            }
        }
    }
}
