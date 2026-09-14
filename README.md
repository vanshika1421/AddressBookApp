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

- Add contact validation
- Validate name, address, city, state, zip, phone number, and email
- Create `InvalidContactException`
- Create `ContactValidator`
- Reject invalid contact data

### UC3 – Add Contacts

- Create `AddressBook` class
- Add multiple contacts
- Display all contacts
- Add console menu for contact management

### UC4 – Edit Contact

- Find a contact using first name and last name
- Edit existing contact details
- Allow blank input to retain existing values
- Validate updated contact details

### UC5 – Delete Contact

- Find a contact using first name and last name
- Delete an existing contact
- Display appropriate success or not-found messages

### UC6 – Count Contacts

- Introduce `AddressBookMain`
- Manage multiple `AddressBook` objects
- Count contacts across multiple address books using LINQ `Sum`

### UC7 – Prevent Duplicate Contacts

- Prevent duplicate contacts based on first name and last name
- Check whether a contact already exists before adding
- Display a duplicate contact message when a duplicate is found

### UC8 – Search Contacts

- Search contacts by city or state
- Search across multiple address books
- Display matching contacts

### UC9 – Group Contacts

- Group contacts by city
- Use LINQ `GroupBy()` to organize contacts
- Group contacts across multiple address books
- Display contacts under their respective city

## Git Workflow

Each Use Case is developed in its own feature branch.

Example:

main
  ↓
feature/UC1-create-contact
  ↓
merge into main