namespace hospital
{
    public class Patient : Person
    {
        private Doctor doctorAssigned;
        public Doctor DoctorAssigned { get { return doctorAssigned; } set { this.doctorAssigned = value; } }

        public Patient(Doctor doctorAssigned, string identification, string name, string lastName, int age) 
                     : base(identification, name, lastName, age)
        {
            this.doctorAssigned = doctorAssigned;
        }


        public override string ToString()
        {
            return $"{base.ToString()} | Tipo de persona: Paciente | Doctor Asignado: {doctorAssigned.Name}";
        }
    }
}
