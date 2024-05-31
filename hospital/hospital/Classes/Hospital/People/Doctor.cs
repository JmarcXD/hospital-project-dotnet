using System.Collections.Generic;
using System.Text;

namespace hospital
{
    public class Doctor : Person
    {
        private List<Patient> listPatients = new List<Patient>(); 
        
        public List<Patient> ListPatients {  get { return listPatients; } set {  listPatients = value; } }
        
        public Doctor(string identification, string name, string lastName, int age) 
                    : base(identification, name, lastName, age)
        {

        }

        public string GetListOwnPatients()
        {
            StringBuilder patientsOfDoctor = new StringBuilder();

            foreach (var patients in listPatients)
            {
                patientsOfDoctor.AppendLine(patients.ToString());
            }

            return patientsOfDoctor.ToString();
        }

        public void AddNewPatient(Patient newPatient)
        {
            this.listPatients.Add(newPatient);
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Tipo de persona: Doctor | Numero de pacientes: {listPatients.Count}";
        }
    }
}
