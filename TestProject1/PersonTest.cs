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
    [TestClass()]
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
        ///A test for setZip
        ///</summary>
        [TestMethod()]
        public void setZipTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "43224";
            target.setZip(p);
            Assert.AreEqual(target.zip, p);
        }

        /// <summary>
        ///A test for setState
        ///</summary>
        [TestMethod()]
        public void setStateTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "VA";
            target.setState(p);
            Assert.AreEqual(target.state, p);
        }

        /// <summary>
        ///A test for setNumber
        ///</summary>
        [TestMethod()]
        public void setNumberTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "987-6543";
            target.setNumber(p);
            Assert.AreEqual(target.num, p);
        }

        /// <summary>
        ///A test for setName
        ///</summary>
        [TestMethod()]
        public void setNameTest()
        {
            string n = "John";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "Jonathon Doe";// TODO: Initialize to an appropriate value
            target.setName(p);
            Assert.AreEqual(target.name,p);
        }

        /// <summary>
        ///A test for setAddress
        ///</summary>
        [TestMethod()]
        public void setAddressTest()
        {
            string n = "John Doe";
            string ad = "101 1st Street";
            string s = "MO";
            string z = "123456";
            string nu = "123-4567";
            Person target = new Person(n, ad, s, z, nu); // TODO: Initialize to an appropriate value
            string p = "404 Not Found Blvd";// TODO: Initialize to an appropriate value
            target.setAddress(p);
            Assert.AreEqual(target.addr,p);
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
            Assert.AreEqual(target.name, n);
            Assert.AreEqual(target.addr, ad);
            Assert.AreEqual(target.state, s);
            Assert.AreEqual(target.zip, z);
            Assert.AreEqual(target.num, nu);

        }
    }
}
