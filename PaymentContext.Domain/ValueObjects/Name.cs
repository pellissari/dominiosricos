using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueOjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName,3, "Name.FirstName", "Nome inválido! Deve conter pelo menos 3 caracteres.")
                .HasMinLen(LastName,3, "Name.LastName", "Sobrenome inválido! Deve conter pelo menos 3 caracteres."));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}