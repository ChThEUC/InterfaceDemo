using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceDemo.Model;

namespace InterfaceDemo.Data
{
    // Her er et eksempel på et repository interface. Interfacet specificerer hvilke metoder vores
    // repository skal supplere os med og hvad de metoder skal kunne modtage, men ikke hvordan de fungerer.
    // Bemærk også at interfacet ikke rummer fields, så vores List<Customer> figurerer ikke.

    // Here's an example of a repository interface. The interface specifies what methods our repository
    // needs to supply us with and what these methods accept as parameters, but not how they function.
    // Also, notice that the interface contains no fields, so our List<Customer> does not appear in it.
    interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        void CreateCustomer(string fullname);
        Customer ReadCustomer(int customerId);
        void UpdateCustomer(ref Customer c, string fullname);
        void DeleteCustomer(Customer c);
    }
}
