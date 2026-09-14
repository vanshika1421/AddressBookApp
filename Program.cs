using AddressBookApp.Exceptions;
using AddressBookApp.Models;
using AddressBookApp.Services;
using AddressBookApp.Validation;

namespace AddressBookApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact(addressBook);
                        break;

                    case "2":
                        addressBook.PrintAll();
                        break;

                    case "3":
                        Console.Write("Enter First Name of contact to edit: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter Last Name of contact to edit: ");
                        string lastName = Console.ReadLine();

                        addressBook.EditContact(firstName, lastName);
                        break;
                    case "4":

                        Console.Write("Enter First Name of contact to delete: ");
                        string deletefirstName = Console.ReadLine();

                        Console.Write("Enter Last Name of contact to delete: ");
                        string deletelastName = Console.ReadLine();

                        addressBook.DeleteContact(deletefirstName, deletelastName);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting Address Book...");
                        break; ;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddContact(AddressBook addressBook)
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact(
                firstName,
                lastName,
                address,
                city,
                state,
                zip,
                phoneNumber,
                email
            );

            try
            {
                ContactValidator.Validate(contact);
                addressBook.AddContact(contact);

                Console.WriteLine("Contact added successfully.");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Invalid Contact: {ex.Message}");
            }
        }
    }
}