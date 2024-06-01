using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class Adopter : Entity
    {
        public NameVO Name { get; set; }
        public Document CPF { get; set; }
        public Address? Address{ get; set; } // Propriedade Navegaçao
        public EmailVO Email { get; set; }
        public string Password { get; set; }                

        public Guid AddressId { get; set; } // FK
        public Adopter(NameVO name, Document cPF, Address address, EmailVO email, string password)
        {
            Name = name;
            CPF = cPF;
            Address = address;
            Email = email;
            Password = password;
        }
    }
}
