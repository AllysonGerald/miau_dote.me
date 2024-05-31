namespace Miaudoteme.Domain.ValueObjects
{
    public class NameVO
    {
        private string Name {  get; set; }
        public NameVO(string name)
        {
            Name = name;
            ValidateName();
        }

        private void ValidateName()
        {
            if (Name.Length < 3) throw new ArgumentException(message: "Nome não pode ter menos de 3 caracteres.");
            if (Name == null) throw new ArgumentException(message: "Nome não pode ser nulo.");

        }
    }
}
