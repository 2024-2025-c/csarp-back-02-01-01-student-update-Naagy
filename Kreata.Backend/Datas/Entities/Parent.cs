namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        public Parent()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = DateTime.MinValue;
            IsFather = false;  
        }

        public Parent(string firstName, string lastName, DateTime birthsDay, bool isFather)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsFather = isFather;
        }

        public Parent(Guid id, string firstName, string lastName, DateTime birthsDay, bool isFather)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsFather = isFather;
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthsDay { get; set; }

        public bool IsFather { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
