using Miaudoteme.Domain.Models;
using Miaudoteme.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudotem.tests
{
    public class ValidationShelterTests
    {
        [Fact]
        public void Deve_Retornar_Um_Shelter_Valido()
        {
            // Arrange
            NameVO nome = new NameVO("Abrigo");
            Document CNPJ = new Document("80256335000104");
            string telefone = "85985858585";
            EmailVO email = new EmailVO("abrigo@gmail.com");
            Address endereco = null;
            NameVO proprietario = new NameVO("Proprietario");


            // Act
            Shelter abrigo = new Shelter(nome, CNPJ, telefone, email, endereco, proprietario);

            // Assert
            Assert.Equal<Shelter>(abrigo, abrigo);
        }
    }
}
