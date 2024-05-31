using System.Collections.Generic;
using System.Text;

namespace hospital.Classes
{
    public class Hospital
    {
        private string hospitalName;
        private List<Person> listPersons = new List<Person>();
        private List<Doctor> listDoctors;
        private List<Patient> listPatients;
        private List<Administrative> listAdministratives;

        public string HospitalName { get { return hospitalName; } set { hospitalName = value; } }
        public List<Person> ListPersons { get { return listPersons; } set { listPersons = value; } }
        public List<Doctor> ListDoctors { get { return listDoctors; } set { listDoctors = value; } }
        public List<Patient> ListPatients { get { return listPatients; } set { listPatients = value; } }
        public List<Administrative> ListAdministratives { get { return listAdministratives; } set { listAdministratives = value; } }

        public Hospital(string hospitalName)
        {
            this.hospitalName = hospitalName;

            this.listPatients = new List<Patient>()
            {
                new Patient (new Doctor ("ID001", "Juan", "Perez",  30),"ID011", "Sofia", "Ruiz", 24),
                new Patient ( new Doctor ("ID002", "Maria", "Garcia", 25 ), "ID012", "Fernando", "Castro", 41),
                new Patient (new Doctor ("ID003", "Carlos", "Lopez", 40 ), "ID013", "Marta", "Ortiz", 26),
                new Patient ( new Doctor ("ID004", "Ana", "Martinez", 35), "ID014", "Diego", "Ramirez", 37),
                new Patient (new Doctor ("ID005", "Pedro", "Gonzalez", 28), "ID015", "Natalia", "Vazquez", 27)
            };
            this.listDoctors = new List<Doctor>()
            {
                new Doctor ("ID001", "Juan", "Perez",  30),
                new Doctor ("ID002", "Maria", "Garcia", 25),
                new Doctor ("ID003", "Carlos", "Lopez", 40 ),
                new Doctor ("ID004", "Ana", "Martinez", 35),
                new Doctor ("ID005", "Pedro", "Gonzalez", 28)
            };

            this.listDoctors[0].AddNewPatient(this.listPatients[0]);
            this.listDoctors[1].AddNewPatient(this.listPatients[1]);
            this.listDoctors[2].AddNewPatient(this.listPatients[2]);
            this.listDoctors[3].AddNewPatient(this.listPatients[3]);
            this.listDoctors[4].AddNewPatient(this.listPatients[4]);

            this.listAdministratives = new List<Administrative>()
            {
                new Administrative ("ID006", "Luis", "Hernandez", 45),
                new Administrative ("ID007", "Laura", "Diaz", 32),
                new Administrative ("ID008", "Jorge", "Morales", 29),
                new Administrative ("ID009", "Elena", "Gutierrez", 33),
                new Administrative ("ID010", "Ricardo", "Jimenez", 38),
            };

            this.listPersons.AddRange(listDoctors);
            this.listPersons.AddRange(listPatients);
            this.listPersons.AddRange(listAdministratives);
        }

        public string GetListPersons()
        {
            StringBuilder persons = new StringBuilder();

            persons.AppendLine(" ");

            foreach (Person d in listPersons)
            {
                persons.AppendLine(d.ToString());
            }

            return persons.ToString();
        }

        public string GetListDoctors()
        {
            StringBuilder doctors = new StringBuilder();

            doctors.AppendLine(" ");

            foreach (Doctor d in listDoctors)
            {
                doctors.AppendLine(d.ToString());
            }

            return doctors.ToString();
        }

        public string GetListPatients()
        {
            StringBuilder patients = new StringBuilder();

            foreach (Patient p in listPatients)
            {
                patients.AppendLine(p.ToString());
            }

            return patients.ToString();
        }

        public string GetListAdministratives()
        {
            StringBuilder administratives = new StringBuilder();

            foreach (Administrative a in listPersons)
            {
                administratives.AppendLine(a.ToString());
            }

            return administratives.ToString();
        }

        public Doctor GetADoctorByIdentification(string identification)
        {

            Doctor doctor = this.listDoctors.Find(d => d.Identification == identification);

            if (doctor != null)
                return doctor;
            else
                return null;
        }

        public Patient GetAPatientByIdentification(string identification)
        {
            Patient patient = this.listPatients.Find(d => d.Identification == identification);

            if (patient != null)
                return patient;
            else
                return null;
        }
        public void RegisterADoctor(Doctor newDoctor)
        {
            this.listPersons.Add(newDoctor);
            this.listDoctors.Add(newDoctor);
        }

        public void RegisterAPatient(Patient newPatient)
        {
            this.listDoctors.Find(d => d == newPatient.DoctorAssigned).AddNewPatient(newPatient); // Añadir en la lista de paciente del medico

            this.listPersons.Add(newPatient);
            this.listPatients.Add(newPatient);
        }

        public void RegisterAAdministrative(Administrative newAdministrative)
        {
            this.listPersons.Add(newAdministrative);
            this.listAdministratives.Add(newAdministrative);
        }

        public void DeleteAPatientByObject(Patient patientToDelete)
        {
            this.listPatients.Remove(patientToDelete);
        }

        public override string ToString()
        {
            return $"Nombre del hospital: {hospitalName} | Numero de personas en el hospital: {listPersons.Count}";
        }
    }
}
