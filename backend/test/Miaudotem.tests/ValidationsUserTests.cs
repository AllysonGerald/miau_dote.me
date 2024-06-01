using Miaudoteme.Domain.Models;
using Miaudoteme.Domain.ValueObjects;

namespace Miaudotem.tests
{
    public class ValidationsUserTests
    {
        [Fact]
        public void DeveRetornarUmUsuarioValido()
        {
            // Arrange
            NameVO name = new NameVO("Mar");
            Document cpf = new Document("60032679335");
            EmailVO email = new EmailVO("marcelo@gmail.com");
            string passworld = "123456";
            Address address = null;
            // Act
            
            var newUser = new Adopter(name, cpf, address, email, passworld);

            // Assert

            Assert.Equal<Adopter>(newUser, newUser);
        }
    }
}
