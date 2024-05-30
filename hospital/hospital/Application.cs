using hospital.Classes;
using System;

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

        private Hospital hospital { get; set; }

        private Application()
        {
            this.hospital = new Hospital("Hospital Sant Fundació Esplai");
        }

        public void HospitalAplication()
        {
            Menu.HospitalMenu();
        }

        public void DeleteAPatient()
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
