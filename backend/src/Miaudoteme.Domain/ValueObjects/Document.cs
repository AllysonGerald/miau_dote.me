namespace Miaudoteme.Domain.ValueObjects
{
    public class Document
    {
        private string NDocumento { get; set; }

        public Document(string document)
        {
            NDocumento = document;
            _ = new ValidateDocument(NDocumento);
        }
    }
}
