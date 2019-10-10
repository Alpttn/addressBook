using System;
using System.Collections.Generic;


namespace addressBook
{
    public class AddressBook
    {
        
        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>(); //instantiate it here in the constructor
        }
        
        public Dictionary<string, Contact> Contacts { get; set;} //define it here

        public void AddContact(Contact contact) {
            Contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email) {
            return Contacts[email];
        }
    }
}