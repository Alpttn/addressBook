using System;
using System.Collections.Generic;


namespace addressBookExercise
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<string> EmailList { get; set;}

        //constructor for contact class
        public Contact() {
            FirstName = "";
            LastName = "";
            Email = "";
            Address = "";
        }

    }

}