using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302FinalProject
{
    //Address book that stored all of the Users, and their information. 
    class AddressBook
    {
        public List<Person> Users = new List<Person>();

        public AddressBook()
        {
        }

        //Adds a user to the list of users
        public void AddUser(Person User)
        {
            Users.Add(User);
        }

        //Removes a user from the list of users
        public void RemoveUser(Person User)
        {
            Users.Remove(User);
        }

        //Sorts the list of users by each user's name. 
        public void SortByName()
        {
            Users=Users.OrderBy(x=>x.Name).ToList();
        }

        //Sorts the list of users by each user's zip code. 
        public void SortByZip()
        {
            Users=Users.OrderBy(x=>x.Zip).ToList();
        }
    
        //Sets all of the selected Person's attirbutes to new values 
        public void EditUser(Person User,string newN,string newAd,string newS,string newZ,string newNu)
        {
            User.Name=newN;
            User.Addr = newAd;
            User.State = newS;
            User.Zip = newZ;
            User.Num = newNu;
        }
    }
}
