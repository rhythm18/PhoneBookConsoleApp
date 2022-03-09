using System;

namespace PhoneBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console PhoneBook App");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact by Number");
            Console.WriteLine("3. View all Contacts");
            Console.WriteLine("4. Search for a contact for a given name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":
                        Console.WriteLine("Enter Contact Number:");
                        var c_number = Console.ReadLine();
                        phoneBook.DisplayContact(c_number);

                        break;

                    case "3":
                        phoneBook.DisplayAllContact();
                        break;

                    case "4":
                        Console.WriteLine("Name Search Phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Enter valid Number");
                        break;
                }

                Console.WriteLine("Select Operation");
                 userInput = Console.ReadLine();

            }

        }
    }
}
