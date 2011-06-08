using System;

namespace IoCConcepts.tests
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public FakeCustomerRepository()
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
        public void Save()
        {
            _WasCalled = true;
        }
    }
}
