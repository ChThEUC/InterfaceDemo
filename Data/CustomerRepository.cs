using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceDemo.Model;

namespace InterfaceDemo.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        List<Customer> allCustomers = new List<Customer>
        {
            new Customer{CustomerId = 0, FirstName = "Allan", LastName = "Allansen"},
            new Customer{CustomerId = 1, FirstName = "Bent", LastName = "Bentsen"}
        };

        public List<Customer> GetAllCustomers()
        {
            return allCustomers;
        }

        public void CreateCustomer(string fullname)
        {
            string[] name = fullname.Split(' ');
            allCustomers.Add(new Customer { CustomerId = allCustomers.Count, FirstName = name[0], LastName = name[name.Length - 11] });
        }

        public Customer ReadCustomer(int cid)
        {
            // return allCustomers[cid];
            return allCustomers.Find(c => c.CustomerId == cid);
        }

        public void UpdateCustomer(int cid, string fullname)
        {
            // Mellemnavne bliver droppet.
            // Middle names are ignored.
            string[] name = fullname.Split(' ');
            ReadCustomer(cid).FirstName = name[0];
            ReadCustomer(cid).LastName = name[name.Length - 1];
        }

        public void UpdateCustomer(ref Customer c, string fullname)
        {
            // Mellemnavne bliver droppet.
            // Middle names are ignored.
            string[] name = fullname.Split(' ');
            c.FirstName = name[0];
            c.LastName = name[name.Length - 1];
        }

        public void DeleteCustomer(Customer c)
        {
            allCustomers.Remove(c);
        }
    }
}
