using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace IoCConcepts.tests
{
    [TestFixture]
    public class CustomerServiceTests
    {
        [Test]
        public void CanEnrollACustomer()
        {
            //Arrange
            FakeCustomerValidator validation = new FakeCustomerValidator();
            FakeCreditCheckValidator creditCheck = new FakeCreditCheckValidator();
            FakeCustomerRepository repository= new FakeCustomerRepository();
            var sut = new CustomerService(validation, creditCheck, repository);
            Customer customer = new Customer();
            //Act
            sut.EnrollCustomer(customer);
            //Assert
            Assert.That(validation.WasCalled);
            Assert.That(creditCheck.WasCalled);
            Assert.That(repository.WasCalled);
        }
    }
}
