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
            string cpf = "12345678900";
            string email = "marcelo@gmail.com";
            string passworld = "123456";

            // Act
            
            var newUser = new User(name, cpf, email, passworld);

            // Assert

            Assert.Equal<User>(newUser, newUser);
        }
    }
}
