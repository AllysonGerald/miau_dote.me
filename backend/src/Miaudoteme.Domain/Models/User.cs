using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class User : Entity
    {
        public NameVO Name { get; set; }
        public Document CPF { get; set; }
        public Address? Address{ get; set; }
        public EmailVO Email { get; set; }
        public string Password { get; set; }

        public User(NameVO name, Document cPF, Address address, EmailVO email, string password)
        {
            Name = name;
            CPF = cPF;
            Address = address;
            Email = email;
            Password = password;
        }
    }
}
