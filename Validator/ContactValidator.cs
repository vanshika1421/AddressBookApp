using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;
using AddressBookApp.Exceptions;
using AddressBookApp.Models;

namespace AddressBookApp.Validation
{
    public class ContactValidator
    {
        public static void Validate(Contact contact)
        {
            if (!Regex.IsMatch(contact.FirstName, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                throw new InvalidContactException(
                    "First Name must start with a capital letter and contain at least 3 characters.");
            }

            if (!Regex.IsMatch(contact.LastName, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                throw new InvalidContactException(
                    "Last Name must start with a capital letter and contain at least 3 characters.");
            }

            if (string.IsNullOrWhiteSpace(contact.Address) ||
                contact.Address.Length < 4)
            {
                throw new InvalidContactException(
                    "Address must contain at least 4 characters.");
            }

            if (string.IsNullOrWhiteSpace(contact.City) ||
                contact.City.Length < 4)
            {
                throw new InvalidContactException(
                    "City must contain at least 4 characters.");
            }

            if (string.IsNullOrWhiteSpace(contact.State) ||
                contact.State.Length < 4)
            {
                throw new InvalidContactException(
                    "State must contain at least 4 characters.");
            }

            if (!Regex.IsMatch(contact.Zip, @"^\d{6}$"))
            {
                throw new InvalidContactException(
                    "Zip must contain exactly 6 digits.");
            }

            if (!Regex.IsMatch(contact.PhoneNumber, @"^\d{10}$"))
            {
                throw new InvalidContactException(
                    "Phone Number must contain exactly 10 digits.");
            }

            if (!Regex.IsMatch(
                    contact.Email,
                    @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new InvalidContactException(
                    "Email is not in a valid format.");
            }
        }
    }
}