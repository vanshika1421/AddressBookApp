using AddressBookApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AddressBookApp.Services
{
    public class AddressBookMain
    {
        private List<AddressBook> addressBooks = new();

        public void AddAddressBook(AddressBook addressBook)
        {
            addressBooks.Add(addressBook);
        }
        public int GetTotalContactCount()
        {
            return addressBooks.Sum(addressBook => addressBook.Contacts.Count);
        }

        public void SearchByCityOrState(string searchValue)
        {
            var contacts = addressBooks
                .SelectMany(b => b.Contacts)
                .Where(c =>
                    c.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase) ||
                    c.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase));
            if (!contacts.Any())
            {
                Console.WriteLine("No contacts found.");
                return;
            }
        }
        public void GroupContactsByCity()
        {
            var groupedContacts = addressBooks.SelectMany(b => b.Contacts).GroupBy(c => c.City);
            foreach (var group in groupedContacts)
            {
                Console.WriteLine($"City : {group.Key}");
                foreach (Contact contact in group)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine();
            }
        }
    }
}