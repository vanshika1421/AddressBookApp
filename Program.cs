using AddressBookApp.Exceptions;
using AddressBookApp.Models;
using AddressBookApp.Validation;

namespace AddressBookApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact(
                "Vanshika",
                "Chhabra",
                "12 MG Road",
                "Ambala",
                "Haryana",
                "134003",
                "9876543210",
                "vanshikagmail.com"
            );

           
            try
            {
                ContactValidator.Validate(contact);

                Console.WriteLine(contact.ToString());
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Invalid Contact: {ex.Message}");
            }
        }
    }
}