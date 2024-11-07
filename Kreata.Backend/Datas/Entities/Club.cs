namespace Kreata.Backend.Datas.Entities
{
    public class Club
    {
        public Club()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = DateTime.MinValue;
        }

        public Club(string firstName, string lastName, DateTime birthsDay)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
        }

        public Club(Guid id, string firstName, string lastName, DateTime birthsDay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthsDay { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
