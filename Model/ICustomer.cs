using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    // Her er et eksempel på et class interface. Bemærk at vores FullName property ikke specificerer
    // hvordan den kommer frem til hvad den skal returnere, i modsætning til den egentlige imple-
    // mentering i selve klassen.
    interface ICustomer
    {
        int CustomerId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
    }
}
