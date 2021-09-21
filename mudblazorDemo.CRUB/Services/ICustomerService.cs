using mudblazorDemo.CRUB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mudblazorDemo.CRUB.Services
{
    interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        void SaveCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
