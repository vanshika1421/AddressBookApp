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

        public void SearchByCityOrState(String searchValue)
        {
            foreach (AddressBook addressBook in addressBooks)
            {
                foreach(Contact contact  in addressBook.Contacts)
                {
                    if(contact.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase) || contact.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                    }
                }
            }
            }
        }
    }
