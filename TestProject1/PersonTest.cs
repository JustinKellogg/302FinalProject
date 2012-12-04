using _302FinalProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestProject1
{  
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
    [TestClass()]////
    public class PersonTest
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
        ///A test for SetZip
        ///</summary>
        [TestMethod()]
        public void SetZipTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "43224";
            target.Zip = p; 
            Assert.AreEqual(target.Zip, p);
        }

        /// <summary>
        ///A test for SetState
        ///</summary>
        [TestMethod()]
        public void SetStateTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); 
            string p = "VA";
            target.State = p;
            Assert.AreEqual(target.State, p);
        }

        /// <summary>
        ///A test for SetNumber
        ///</summary>
        [TestMethod()]
        public void SetNumberTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); 
            string p = "987-6543";
            target.Num = p;
            Assert.AreEqual(target.Num, p);
        }

        /// <summary>
        ///A test for setName
        ///</summary>
        [TestMethod()]
        public void SetNameTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "Jonathon Doe";// TODO: Initialize to an appropriate value
            target.Name = p;
            Assert.AreEqual(target.Name,p);
        }

        /// <summary>
        ///A test for SetAddress
        ///</summary>
        [TestMethod()]
        public void SetAddressTest()
        {
            string n = "John Doe";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "404 Not Found Blvd";// TODO: Initialize to an appropriate value
            target.Addr = p;
            Assert.AreEqual(target.Addr,p);
        }

        /// <summary>
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu);
            Assert.AreEqual(target.Name, n);
            Assert.AreEqual(target.Addr, ad);
            Assert.AreEqual(target.State, s);
            Assert.AreEqual(target.Zip, z);
            Assert.AreEqual(target.Num, nu);
        }
    }
}
