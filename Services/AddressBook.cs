using System;
using System.Collections.Generic;
using AddressBookApp.Models;
using AddressBookApp.Exceptions;
using AddressBookApp.Validation;

namespace AddressBookApp.Services
{
    public class AddressBook
    {
        private List<Contact> contacts = new();

        public IReadOnlyList<Contact> Contacts => contacts;

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void PrintAll()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.Write($"First Name ({contact.FirstName}): ");
            string newFirstName = Console.ReadLine();

            Console.Write($"Last Name ({contact.LastName}): ");
            string newLastName = Console.ReadLine();

            Console.Write($"Address ({contact.Address}): ");
            string newAddress = Console.ReadLine();

            Console.Write($"City ({contact.City}): ");
            string newCity = Console.ReadLine();

            Console.Write($"State ({contact.State}): ");
            string newState = Console.ReadLine();

            Console.Write($"Zip ({contact.Zip}): ");
            string newZip = Console.ReadLine();

            Console.Write($"Phone Number ({contact.PhoneNumber}): ");
            string newPhoneNumber = Console.ReadLine();

            Console.Write($"Email ({contact.Email}): ");
            string newEmail = Console.ReadLine();

            Contact updatedContact = new Contact(
                string.IsNullOrWhiteSpace(newFirstName) ? contact.FirstName : newFirstName,
                string.IsNullOrWhiteSpace(newLastName) ? contact.LastName : newLastName,
                string.IsNullOrWhiteSpace(newAddress) ? contact.Address : newAddress,
                string.IsNullOrWhiteSpace(newCity) ? contact.City : newCity,
                string.IsNullOrWhiteSpace(newState) ? contact.State : newState,
                string.IsNullOrWhiteSpace(newZip) ? contact.Zip : newZip,
                string.IsNullOrWhiteSpace(newPhoneNumber) ? contact.PhoneNumber : newPhoneNumber,
                string.IsNullOrWhiteSpace(newEmail) ? contact.Email : newEmail
            );

            try
            {
                ContactValidator.Validate(updatedContact);

                contact.FirstName = updatedContact.FirstName;
                contact.LastName = updatedContact.LastName;
                contact.Address = updatedContact.Address;
                contact.City = updatedContact.City;
                contact.State = updatedContact.State;
                contact.Zip = updatedContact.Zip;
                contact.PhoneNumber = updatedContact.PhoneNumber;
                contact.Email = updatedContact.Email;

                Console.WriteLine("Contact updated successfully.");
            }
            catch (InvalidContactException ex)
            {
                Console.WriteLine($"Invalid Contact: {ex.Message}");
            }
        }
        public void DeleteContact(string firstName , string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if(contact == null)
            {
                Console.WriteLine("Contact Not Found!");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("Contact Removed Successfully");
        }
        private Contact FindContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return contact;
                }
            }

            return null;
        }
    }
}