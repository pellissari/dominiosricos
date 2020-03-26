using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenNameIsTooLong()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "AndreAndreAndreAndreAndreAndreAndse";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenNameIsValid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";

            command.Validate();
            Assert.AreEqual(true, command.Valid);
        }
    }
}

