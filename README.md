# Address Book App

A console-based Address Book application developed in C#.

## Project Objective

The application is developed incrementally using multiple Use Cases (UC1–UC12).
Each Use Case is implemented in a separate Git branch and merged into the `main`
branch after completion and testing.

## Technology

- C#
- .NET
- Visual Studio
- Git

## Current Progress

### UC1 – Create Contact

- Create a Contact class
- Store contact details
- Initialize a contact using a constructor
- Display contact details using `ToString()`

### UC2 – Validate Contact

- Validate contact details
- Add custom `InvalidContactException`
- Validate name, address, city, state, zip, phone number, and email
- Display clear validation error messages

### UC3 – Add Multiple Contacts

- Create an `AddressBook` class
- Store multiple contacts using a list
- Add contacts to the address book
- Display all contacts
- Add a console menu for address book operations

### UC4 – Edit Contact

- Find an existing contact using first name and last name
- Edit contact details
- Keep existing values when a field is left blank
- Validate updated contact details
- Update the contact if the new details are valid

### UC5 – Delete Contact

- Find an existing contact using first name and last name
- Delete the selected contact from the address book
- Display a message when the contact is not found
- Display a confirmation message after successful deletion

## Git Workflow

Each Use Case is developed in its own feature branch.

Example:

main
  ↓
feature/UC1-create-contact
  ↓
merge into main