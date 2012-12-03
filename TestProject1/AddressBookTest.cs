﻿using _302FinalProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace TestProject1
{      
    /// <summary>
    ///This is a test class for AddressBookTest and is intended
    ///to contain all AddressBookTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AddressBookTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddressBook Constructor
        ///</summary>
        [TestMethod()]
        public void AddressBookConstructorTest()
        {
            List<int> test = new List<int>(); 
            
            AddressBook target = new AddressBook();
            Assert.IsNotNull(target);
            Assert.AreEqual(target.Users.Count,0);
        }

        /// <summary>
        ///A test for addUser
        ///</summary>
        [TestMethod()]
        public void addUserTest()
        {
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person User = new Person(n, ad, s, z, nu);           

            target.addUser(User);
            Assert.IsTrue(target.Users.Contains(User));
            Assert.AreEqual(target.Users.Count, 1);
            Assert.AreEqual(target.Users[0].name, n);
            Assert.AreEqual(target.Users[0].addr, ad);
            Assert.AreEqual(target.Users[0].state, s);
            Assert.AreEqual(target.Users[0].zip, z);
            Assert.AreEqual(target.Users[0].num, nu);
            target.addUser(User);
            Assert.AreEqual(target.Users.Count, 2);

        }
        ///<summary>
        ///A test for editUser
        ///</summary>
        [TestMethod()]
        public void editUserTest()
        {
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person User = new Person(n, ad, s, z, nu);

            string newN = "Jane";
            string newAd = "404 2nd Street";
            string newS = "MN";
            string newZ = "012345";
            string newNu = "321-7654";

            target.addUser(User);
            target.editUser(User,newN,newAd,newS,newZ,newNu);

            Assert.AreEqual(target.Users[0].addr, newN);
            Assert.AreEqual(target.Users[0].addr, newAd);
            Assert.AreEqual(target.Users[0].addr, newS);
            Assert.AreEqual(target.Users[0].addr, newZ);
            Assert.AreEqual(target.Users[0].addr, newNu);
        }

        /// <summary>
        ///A test for removeUser
        ///</summary>
        [TestMethod()]
        public void removeUserTest()
        {
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person User = new Person(n, ad, s, z, nu);
            target.addUser(User);

            Assert.AreEqual(target.Users.Count, 1);
            Assert.IsTrue(target.Users.Contains(User));
            target.removeUser(User);
            Assert.AreEqual(target.Users.Count, 0);
            Assert.IsFalse(target.Users.Contains(User));
        }

        /// <summary>
        ///A test for sortByZip
        ///</summary>
        [TestMethod()]
        public void sortByZipTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";

            string n2 = "Zach";
            string ad2 = "404 2nd Street";
            string s2 = "MN";
            string z2 = "012345";
            string nu2 = "321-7654";
            Person User = new Person(n, ad, s, z, nu);
            Person User2 = new Person(n2, ad2, s2, z2, nu2);
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value        
            target.addUser(User);
            target.addUser(User2);

            target.sortByZip();
            Assert.AreEqual(target.Users[0].zip, "012345");
            Assert.AreEqual(target.Users[1].zip, "123456");
            Assert.AreEqual(target.Users[1].name, "John");
            Assert.AreEqual(target.Users[0].name, "Zach");
        }

        /// <summary>
        ///A test for sortByName
        ///</summary>
        [TestMethod()]
        public void sortByNameTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";

            string n2 = "Zach";
            string ad2 = "404 2nd Street";
            string s2 = "MN";
            string z2 = "012345";
            string nu2 = "321-7654";
            Person User = new Person(n, ad, s, z, nu);
            Person User2 = new Person(n2, ad2, s2, z2, nu2);
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value        
            target.addUser(User2);
            target.addUser(User);

            target.sortByName();
            Assert.AreEqual(target.Users[0].name,"John");
            Assert.AreEqual(target.Users[1].name,"Zach");
            Assert.AreEqual(target.Users[1].zip,"012345");
            Assert.AreEqual(target.Users[0].zip,"123456");
        }
    }
}
