using AddressBookApp.Models;
using System;
using System.Collections.Generic;
using System.Text;



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

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
