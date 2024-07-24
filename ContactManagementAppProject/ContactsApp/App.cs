using ContactManagementAppProject.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ContactManagementAppProject.ContactsApp
{
    public class App
    {
        public List<ContactUser> contacts { get; set; }

        public App()
        {
            contacts = new List<ContactUser>();
        }
        public void DisplayListOfContacts()
        {
            Console.WriteLine("Contact List Menu");
            foreach (ContactUser contactUser in contacts)
            {
                Console.WriteLine("index :{0,5}. First Name: {1,-10} Last Name: {2,-20} E-mail: {3,-30} Phone Number: {4,-40}", contactUser.FirstName, contactUser.LastName, contactUser.Email, contactUser.PhoneNumber);
            }
        }
        public void CreateContact()
        {
            Console.WriteLine("Enter contact's First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter contact's Last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter contact's e-mail address");
            string email = Console.ReadLine();
            Console.WriteLine("Enter contact's phone number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            DateTime dob;

            while (true)
            {
                Console.WriteLine("Enter the date of birth of student (DD/MM/YYYY)");
                string dobInput = Console.ReadLine();
                if (DateTime.TryParseExact(dobInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob))
                {
                    int contactUser = contacts.Count + 1;
                    contacts.Add(new ContactUser(contactUser, firstName, lastName, email, phoneNumber, dob));
                    Console.WriteLine("You have successfully added a new Contact in your Directory");
                    Console.WriteLine("Please enter any key to return to previous menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter the date in DD/MM/YYYY format.");
                }

            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of contact");
            string contactUser = Console.ReadLine();
            ContactUser contactToDelete = contacts.Find(x => x.FirstName == contactUser || x.LastName == contactUser);
            contacts.Remove(contactToDelete);
            Console.WriteLine($"{contactToDelete} has now been deleted from your directory");
        }
        public void EditContact()
        {
            Console.WriteLine("Select a contact to edit");
            DisplayListOfContacts();

           
        }
    }

}
