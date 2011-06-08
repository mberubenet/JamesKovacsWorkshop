using System;

namespace IoCConcepts
{
    public class CustomerValidator : ICustomerValidator
    {
        public void Validate(Customer customer)
        {
            throw new NotImplementedException();
        }
        public CustomerValidator()
        {
        }
    }
}
