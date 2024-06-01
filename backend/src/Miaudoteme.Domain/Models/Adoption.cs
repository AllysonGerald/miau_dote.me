using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class Adoption : Entity
    {
        public string CodAdoption { get; set; }
        public DateTime DateAdoption { get; set; }
        public Adopter Adopter { get; set; }
        public Animal Animal { get; set; }
        public ContributionForm ContributionForm { get; set; }
        public decimal Amount { get; set; }
        public StatusAdoption StatusAdoption { get; set; }

        public Adoption(Adopter adopter, Animal animal)
        {
            CodAdoption = Id.ToString().Replace("-", "")[..10];
            DateAdoption = DateTime.Now;
            Adopter = adopter;
            Animal = animal;
            ContributionForm = ContributionForm.CardCred;
            Amount = 0;
            StatusAdoption = StatusAdoption.Started;
        }
    }
}
