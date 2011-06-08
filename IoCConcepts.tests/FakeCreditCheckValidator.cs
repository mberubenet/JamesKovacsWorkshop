using System;

namespace IoCConcepts.tests
{
    public class FakeCreditCheckValidator : ICreditCheck
    {
        public FakeCreditCheckValidator()
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
        public void Check(Customer customer)
        {
            _WasCalled = true;
        }
    }
}
