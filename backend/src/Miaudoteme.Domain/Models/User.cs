using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class User : Entity
    {
        public NameVO Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(NameVO name, string cPF, string email, string password)
        {
            Name = name;
            CPF = cPF;
            Email = email;
            Password = password;
        }
    }
}
