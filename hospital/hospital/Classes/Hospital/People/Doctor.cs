using System.Collections.Generic;
using System.Text;

namespace hospital.Classes.People
{
    public class Doctor : Person
    {
        private List<Patient> listPatients = new List<Patient>(); 
        public Doctor(string identification, string name, string lastName, int age) 
                    : base(identification, name, lastName, age){}

        public List<Patient> ListPatients {  get { return listPatients; } set {  listPatients = value; } }


        public string ListOfPatients()
        {
            StringBuilder patientsOfDoctor = new StringBuilder();

            foreach (var patients in listPatients)
            {
                patientsOfDoctor.AppendLine(patients.ToString());
            }

            return patientsOfDoctor.ToString();
        }

        public override string ToString()
        {
            return $"{this} | Tipo de persona: Doctor | Numero de pacientes: {listPatients.Count}";
        }
    }
}
