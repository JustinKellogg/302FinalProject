using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302FinalProject
{
    class AddressBook
    {
        public List<Person> Users = new List<Person>();
        internal void addUser(Person User)
        {
            Users.Add(User);
        }

        internal void removeUser(Person User)
        {
            Users.Remove(User);
        }
        internal void sortByName()
        {
            Users=Users.OrderBy(x=>x.name).ToList();
        }
        internal void sortByZip()
        {
            Users=Users.OrderBy(x=>x.zip).ToList();
        }
    
        internal void editUser(Person User,string newN,string newAd,string newS,string newZ,string newNu)
        {
            User.setName(newN);
            User.setAddress(newAd);
            User.setState(newS);
            User.setZip(newZ);
            User.setNumber(newNu);
        }
    }
}
