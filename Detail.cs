using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingLambda
{
    public class Detail
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;

        public Detail(string firstname, string lastName, string email, string phoneNumber)
        {
            FirstName = firstname;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
