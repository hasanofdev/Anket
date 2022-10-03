namespace Anket
{
    class User
    {
        public User(string name, string surname, string father, string country, string city, string phone, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Father = father;
            Country = country;
            City = city;
            Phone = phone;
            BirthDate = birthDate;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Father { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
    }
}