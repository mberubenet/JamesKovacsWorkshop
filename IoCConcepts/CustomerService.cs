using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IoCConcepts
{
    public class CustomerService
    {
        private readonly ICustomerValidator _Validator;
        private readonly ICreditCheck _CreditCheck;
        private readonly ICustomerRepository _Repository;
        /// <summary>
        /// Initializes a new instance of the CustomerService class.
        /// </summary>
        public CustomerService():this(new CustomerValidator(),new CreditCheck(),new CustomerRepository())
        {
            
        }
        public CustomerService(ICustomerValidator customerValidator, ICreditCheck creditCheck, ICustomerRepository customerRepository)
        {
            _Validator = customerValidator;
            _CreditCheck = creditCheck;
            _Repository = customerRepository;
        }
        public void EnrollCustomer(Customer customer)
        {
            _Validator.Validate(customer);   
            _CreditCheck.Check(customer);
            _Repository.Save();
        }
    }
}
