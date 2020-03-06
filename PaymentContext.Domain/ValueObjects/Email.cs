using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueOjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}