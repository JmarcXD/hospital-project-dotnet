namespace hospital.Classes.People
{
    public class Administrative : Person
    {
        public Administrative(string identification, string name, string lastName, int age)
                            : base(identification, name, lastName, age)
        {
        }

        public override string ToString()
        {
            return $"{this} | Tipo de persona: Personal Administrativo"; 
        }
    }
}
