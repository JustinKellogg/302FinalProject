using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302FinalProject
{
    //Person class holds all information on a person in address book
    class Person
    {
        public string name,addr,state,zip,num;
        public Person(string n, string ad, string s, string z, string nu)
        {
            name = n;///
            addr = ad;
            state = s;
            zip = z;
            num = nu;
        }
        
        //Sets Name
        public void SetName(string p)
        {
            name = p;
        }

        //Sets Address
        public void SetAddress(string p)
        {
            addr = p;
        }

        //Sets State
        public void SetState(string p)
        {
            state = p;
        }

        //Sets Zip
        public void SetZip(string p)
        {
           zip = p;
        }

        //Sets Number
        public void SetNumber(string p)
        {
           num = p;
        }
    }
}

