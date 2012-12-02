using _302FinalProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

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
            AddressBook target = new AddressBook();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for addUser
        ///</summary>
        [TestMethod()]
        public void addUserTest()
        {
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value
            Person User = null; // TODO: Initialize to an appropriate value
            target.addUser(User);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for removeUser
        ///</summary>
        [TestMethod()]
        public void removeUserTest()
        {
            AddressBook target = new AddressBook(); // TODO: Initialize to an appropriate value
            Person User = null; // TODO: Initialize to an appropriate value
            target.removeUser(User);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
