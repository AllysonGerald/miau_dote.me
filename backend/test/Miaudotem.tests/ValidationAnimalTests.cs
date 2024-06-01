using Miaudoteme.Domain.Models;
using Miaudoteme.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miaudotem.tests
{
    
    public class ValidationAnimalTests
    {
        [Fact]
       public void Deve_Retornar_Um_Animal_Valido()
       {
            //Arrange
            var nome = new NameVO("Meu Doguinho");
            string raca = "Vira-Lata";
            int ano = 2010;
            string about = "Sobre o animalzinho";

            //Act
            var animal = new Animal(nome, raca, ano, about);

            //Assert
            Assert.Equal<Animal>(animal, animal);

       }
    }
}