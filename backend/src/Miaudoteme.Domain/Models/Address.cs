namespace Miaudoteme.Domain.Models
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }   

        public Address(string street, string number, string complement, string neighborhood string city, string state)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }    

    }
}
