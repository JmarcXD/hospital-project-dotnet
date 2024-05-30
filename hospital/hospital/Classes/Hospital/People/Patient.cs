namespace hospital.Classes.People
{
    public class Patient : Person
    {
        private Doctor doctorAssigned;

        public Patient(Doctor doctorAssigned, string identification, string name, string lastName, int age) 
                     : base(identification, name, lastName, age)
        {
            this.doctorAssigned = doctorAssigned;
        }

        public Doctor DoctorAssigned { get { return doctorAssigned; } set { this.doctorAssigned = value; } }

        public override string ToString()
        {
            return $"{this} | Tipo de persona: Paciente | Doctor Asignado: {doctorAssigned}";
        }
    }
}
