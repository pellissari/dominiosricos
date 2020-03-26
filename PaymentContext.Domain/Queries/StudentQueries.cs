using System;
using System.Linq.Expressions;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        public static Expression<Func<Student, bool>> GetStudentInfoByDoc(string document)
        {
            return x => x.Document.Number == document;
        }

        public static Expression<Func<Student, bool>> GetStudentInfoByEmail(string email)
        {
            return x => x.Email.Address == email;
        }        

    }
}