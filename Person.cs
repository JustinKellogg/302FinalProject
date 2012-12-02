using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302FinalProject
{
    class Person
    {
        public string name,addr,state,zip,num;
        public Person(string n, string ad, string s, string z, string nu)
        {
            name = n;
            addr = ad;
            state = s;
            zip = z;
            num = nu;
        }
        internal void setName(string p)
        {
            name = p;
        }

        internal void setAddress(string p)
        {
            addr = p;
        }

        internal void setState(string p)
        {
            state = p;
        }

        internal void setZip(string p)
        {
           zip = p;
        }

        internal void setNumber(string p)
        {
           num = p;
        }
    }
}

