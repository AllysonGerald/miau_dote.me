using Miaudoteme.Domain.ValueObjects;

namespace Miaudoteme.Domain.Models
{
    public class Animal : Entity
    {
        public NameVO Name { get; set; }
        public string? Race { get; set; }
        public int YearBirth { get; set; }
        public int Age { get; set; }
        public string? About { get; set; }
        public Gander Gander { get; set; }
        
        public Animal(NameVO name, string race, int yearBirth, string About)
        {
            Name = name;
            Race = race;
            YearBirth = yearBirth;
            Age = CalcAge(yearBirth);
            About = About;
        }   

        private int CalcAge(int year)
        {
            var yearNow = DateTime.Now.Year;
            var age = yearNow - YearBirth;
            return age;
        }     
    }
}
