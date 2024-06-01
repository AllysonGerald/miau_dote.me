using Miaudoteme.Domain.Models;

namespace Miaudotem.tests
{
    public class ValidateAddressTest
    {
        [Fact]
        public void Deve_Retornar_Um_Endereco_Valido()
        {
            // Arrange
            string street = "Rua de Teste";
            string number = "102";
            string complement = "A";
            string neighborhood = "Bairro de teste";
            string city = "Fortaleza";
            string state = "Ceara";

            // Act
            Address endereco = new Address(street, number, complement, neighborhood, city, state);

            // Assert
            Assert.Equal<Address>(endereco, endereco);
        }
    }
}