using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsole
{
    class PhoneBook
    {


        private List<Contact> _contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Name}, {contact.Number}");

        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);

        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if(contact == null)
            {
                Console.WriteLine("Contact Not Found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContact()
        {
            DisplayContactDetails(_contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            //searchPhrase = ll
            //name = Bill

            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();

            foreach (var contact in matchingContacts)
            {
                DisplayContactDetails(matchingContacts);

            }

        }
    }
}
