using Miaudoteme.Domain.Models;
using Miaudoteme.Domain.ValueObjects;

namespace Miaudotem.tests
{
    public class ValidateAdoptionTest
    {
        [Fact]
        public void Deve_Retornar_Uma_Adocao_Valida()
        {
            // Arrange
        
            Animal animal= new Animal(new NameVO("Meu Doguinho"), "Vira-Lata", 2010, "Sobre o animalzinho");
            Adopter adoprer= new Adopter(new NameVO("Marcelo"), new Document("60032679335"), null, new EmailVO("marcelo@gmail.com"), "123456") ;

            // Act
            Adoption adocao = new Adoption(adoprer, animal);

            // Assert
            Assert.Equal<Adoption>(adocao, adocao);
        }
    }
}