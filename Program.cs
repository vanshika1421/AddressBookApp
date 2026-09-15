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
            AddressBook addressBook1 = new AddressBook();
            AddressBook addressBook2 = new AddressBook();
            AddressBookMain addressBookMain = new AddressBookMain();


            addressBookMain.AddAddressBook(addressBook);
            addressBookMain.AddAddressBook(addressBook1);
            addressBookMain.AddAddressBook(addressBook2);


            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Count Contacts");
                Console.WriteLine("6. Search Contact");
                Console.WriteLine("7. Group Contact by city");
                Console.WriteLine("8. Count Contact By City or State");
                Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    
                    case "1":
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
                        }
                        catch (InvalidContactException ex)
                        {
                            Console.WriteLine($"Invalid Contact: {ex.Message}");
                        }

                        break;

                    case "2":
                        if (addressBook.Contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            addressBook.PrintAll();
                        }
                        break;

                    case "3":
                        if (addressBook.Contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            Console.Write("Enter First Name of contact to edit: ");
                            string firstName_to_edit = Console.ReadLine();

                            Console.Write("Enter Last Name of contact to edit: ");
                            string lastName_to_edit = Console.ReadLine();

                            addressBook.EditContact(firstName_to_edit, lastName_to_edit);
                        }
                        break;

                    case "4":
                        if (addressBook.Contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            Console.Write("Enter First Name of contact to delete: ");
                            string deletefirstName = Console.ReadLine();

                            Console.Write("Enter Last Name of contact to delete: ");
                            string deletelastName = Console.ReadLine();

                            addressBook.DeleteContact(deletefirstName, deletelastName);
                        }
                        break;

                    case "5":
                        Console.WriteLine($"Total Contacts: {addressBookMain.GetTotalContactCount()}");
                        break;

                    case "6":
                        Console.WriteLine("Enter City/state to search");
                        string searchValue = Console.ReadLine();
                        addressBookMain.ViewByCityOrState(searchValue);
                        break;

                    case "7":
                        if (addressBook.Contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            addressBookMain.GroupContactsByCity();
                        }
                        break;

                    case "8":
                        if (addressBook.Contacts.Count == 0)
                        {
                            Console.WriteLine("No contacts available.");
                        }
                        else
                        {
                            addressBook.GetCountByCityOrState();
                        }
                        break;

                    case "9":
                        running = false;
                        Console.WriteLine("Exiting Address Book...");
                        break;
                }
            }

            
        }
    }
}