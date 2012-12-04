using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302FinalProject
{
    //Person class holds all information on a person in address book
    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
             }
        }

        private string addr;
        public string Addr
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }
        }

        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        private string zip;
        public string Zip
         {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        private string num;
        public string Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public Person(string n, string ad, string s, string z, string nu)
        {
            Name = n;///
            Addr = ad;
            State = s;
            Zip = z;
            Num = nu;
        }
        
        //Sets Name
 /*       public void SetName(string p)
        {
            FullName = p;
        }

        //Sets Address
        public void SetAddress(string p)
        {
            Addr = p;
        }

        //Sets State
        public void SetState(string p)
        {
            State = p;
        }

        //Sets Zip
        public void SetZip(string p)
        {
           Zip = p;
        }

        //Sets Number
        public void SetNumber(string p)
        {
           Num = p;
        }*/
    }
  
}

