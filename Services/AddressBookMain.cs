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
    }
}
