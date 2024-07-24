using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementAppProject.Contact
{
    public class ContactUser //properties
    {
        int id {  get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public int PhoneNumber { get; set; } 

        DateTime DateTime { get; set; }

        public ContactUser( int id, string firstName, string lastName, string email, int phoneNumber, DateTime dateTime) //Constructor
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateTime = dateTime;
        }
    }
}
