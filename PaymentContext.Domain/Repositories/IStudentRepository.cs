using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepositories
    {
        bool DocumetExists();
        bool EmailExists();
        void CreateSubscription(Student student);
    }
}   