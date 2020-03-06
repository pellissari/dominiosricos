using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueOjects;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var name = new Name("André","Pellissari");
            var document = new Document("123456",EDocumentType.CPF);
            var email = new Email("teste@pellissari.com.br");
            
            var student = new Student(name,document,email);
            student.AddSubscription(subscription);
        }
    }
}
