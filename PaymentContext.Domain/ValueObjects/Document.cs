using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            this.number = number;
            Type = type;

            AddNotifications(new Contract()
            .Requires()
            .IsTrue(Validate(), "Document.Number","Documento inválido")
            );
        }

        public string number { get; private set; }

        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && number.Length == 11)
                return true;

            return false;
        }
    }
}