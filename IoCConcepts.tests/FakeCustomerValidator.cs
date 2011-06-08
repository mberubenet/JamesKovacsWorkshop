using System;

namespace IoCConcepts.tests
{
    public class FakeCustomerValidator : ICustomerValidator
    {
        public FakeCustomerValidator()
        {
        }
        private bool _WasCalled;
        public bool WasCalled
        {
            get
            {
                return _WasCalled;
            }
        }
        public void Validate(Customer customer)
        {
            _WasCalled = true;
        }
    }
}
