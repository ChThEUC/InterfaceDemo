using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo.Model
{
    // Her er et eksempel på et class interface. Bemærk at vores FullName property ikke specificerer
    // hvordan den kommer frem til hvad den skal returnere, i modsætning til den egentlige imple-
    // mentering i selve klassen. Bemærk også, at interfaces ikke rummer fields og kun properties.

    // Here is an example of a class interface. Notice how our FullName property doesn't specify how
    // it arrives at its return value, as opposed to the actual implementation of the property in the
    // class itself. Also, notice how the interface only contains properties and no fields.
    interface ICustomer
    {
        int CustomerId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
    }
}
