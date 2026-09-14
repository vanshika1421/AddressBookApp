using AddressBookApp.Models;

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
                "vanshika@gmail.com"
            );

            Console.WriteLine(contact.ToString());
        }
    }
}