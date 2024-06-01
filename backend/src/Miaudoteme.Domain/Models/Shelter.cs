using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class Shelter : Entity
    {
        public NameVO Name { get; set; }
        public Document CNPJ { get; set; }
        public string Phone {  get; set; }
        public EmailVO Email { get; set; }
        public Address? Address { get; set; }
        public NameVO Owner { get; set; }

        public Shelter(NameVO name, Document cNPJ, string phone, EmailVO email, Address address, NameVO owner)
        {
            Name = name;
            CNPJ = cNPJ;
            Phone = phone;
            Email = email;
            Address = address;
            Owner = owner;
        }
    }
}
