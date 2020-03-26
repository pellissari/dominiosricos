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

        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Student _student;
        private readonly Address _address;

        public StudentTests()
        {
            _name = new Name("Bruce", "Wayne");
            _document = new Document("66511278026", EDocumentType.CPF);
            _email = new Email("batman@dc.com");
            _student = new Student(_name, _document, _email);
            _address = new Address("Wayne Street", "1000", "Central", "Gothan", "NY", "USA", "03300");

        }
        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {

            var subscription = new Subscription(null);
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp.", _document, _address, _email);
            subscription.AddPayment(payment);
            _student.AddSubscription(subscription);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var subscription = new Subscription(null);
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp.", _document, _address, _email);
            subscription.AddPayment(payment);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            var subscription = new Subscription(null);
            _student.AddSubscription(subscription);

            Assert.IsTrue(_student.Invalid);
        }

    }
}
