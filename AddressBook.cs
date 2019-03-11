using System;
using System.Collections.Generic;

/*
    1. Add the required classes to make the following code compile.
    HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

    2. Run the program and observe the exception.

    3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
        Print meaningful error messages in the catch blocks.
*/


namespace trycatch_addressbook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> ContactDict = new Dictionary<string, Contact>();

        public void AddContact(Contact contact) {
            try
            {
                ContactDict.Add(contact.Email, contact);
                Console.WriteLine($"{contact.FullName} was added to address book.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{contact.FullName} is already in the address book!");
            }
        }

        public Contact GetByEmail(string email) {
            try {
                Contact contactToReturn = ContactDict[email];
                return contactToReturn;
            }
            catch (KeyNotFoundException) {
                return null;
            }

        }
    }
}
