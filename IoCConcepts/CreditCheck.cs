using System;

namespace IoCConcepts
{
    public class CreditCheck : ICreditCheck
    {
        public void Check(Customer customer)
        {
            throw new NotImplementedException();
        }
        public CreditCheck()
        {
        }
    }
}
