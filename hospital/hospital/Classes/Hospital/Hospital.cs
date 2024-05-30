using hospital.Classes.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace hospital.Classes
{
    public class Hospital
    {
        private string hospitalName;
        private List<Person> people = new List<Person>();

        public Hospital(string hospitalName) 
        { 
            this.hospitalName = hospitalName;
        }

        public string HospitalName { get {  return hospitalName; } set { hospitalName = value; } }
        public List<Person> People { get {  return people; } set {  people = value; } }

        public string ListDoctors()
        {
            StringBuilder doctors = new StringBuilder();

            doctors.AppendLine(" ");

            foreach (Person person in people) 
            {
                if (person is Doctor)
                    doctors.AppendLine(person.ToString());
            }

            return doctors.ToString();
        }

        public string ListPatients()
        {
            StringBuilder patients = new StringBuilder();

            foreach (Person person in people)
            {
                if (person is Patient)
                    patients.AppendLine(person.ToString());
            }

            return patients.ToString();
        }

        public string ListAdministratives()
        {
            StringBuilder administratives = new StringBuilder();

            foreach (Person person in people)
            {
                if (person is Doctor)
                    administratives.AppendLine(person.ToString());
            }

            return administratives.ToString();
        }

        public override string ToString()
        {
            return $"Nombre del hospital: {hospitalName} | Numero de personas en el hospital: {people.Count}";
        }
    }
}
