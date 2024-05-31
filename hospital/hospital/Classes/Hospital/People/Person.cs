namespace hospital
{
    public class Person
    {
        private string identification;
        private string name;
        private string lastName;
        private int age;

        public string Identification { get { return identification; } set { this.identification = value; } }
        public string Name { get { return name; } set { this.name = value; } }
        public string LastName { get { return lastName; } set { this.lastName = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string identification, string name, string lastName, int age)
        {
            this.identification = identification;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Persona: {name} {lastName} | Identificación: {identification} | Edad: {age} años";
        }
    }
}
