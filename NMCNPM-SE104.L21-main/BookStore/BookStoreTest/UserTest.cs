using NUnit.Framework;
using BookStore.ViewModel;

namespace BookStoreTest
{
    class UserTest
    {
        private AddUserViewModel addUserViewModel;
        [SetUp]
        public void Setup()
        {
            addUserViewModel = new AddUserViewModel(true);
        }

        [Test]
        public void addUser_1()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("  ", "  ", "  "));
        }

        [Test]
        public void addUser_2()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("  ", "  ", "abc"));
        }

        [Test]
        public void addUser_3()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("  ", "abc", "  "));
        }

        [Test]
        public void addUser_4()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("  ", "abc", "abc"));
        }

        [Test]
        public void addUser_5()
        {
            Assert.AreEqual(true, addUserViewModel.addUser("abc", "  ", "  "));
        }

        [Test]
        public void addUser_6()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("abc", "  ", "abc"));
        }

        [Test]
        public void addUser_7()
        {
            Assert.AreEqual(false, addUserViewModel.addUser("abc", "abc", "  "));
        }

        [Test]
        public void addUser_8()
        {
            Assert.AreEqual(true, addUserViewModel.addUser("abc", "abc", "abc"));
        }

        [Test]
        public void updateUser_1()
        {
            Assert.AreEqual(false, addUserViewModel.updateUser("  ", "  ", "  "));
        }

        [Test]
        public void updateUser_2()
        {
            Assert.AreEqual(false, addUserViewModel.updateUser("  ", "  ", "abc"));
        }

        [Test]
        public void updateUser_3()
        {
            Assert.AreEqual(true, addUserViewModel.updateUser("  ", "abc", "  "));
        }

        [Test]
        public void updateUser_4()
        {
            Assert.AreEqual(false, addUserViewModel.updateUser("  ", "abc", "abc"));
        }

        [Test]
        public void updateUser_5()
        {
            Assert.AreEqual(true, addUserViewModel.updateUser("abc", "  ", "  "));
        }

        [Test]
        public void updateUser_6()
        {
            Assert.AreEqual(false, addUserViewModel.updateUser("abc", "  ", "abc"));
        }

        [Test]
        public void updateUser_7()
        {
            Assert.AreEqual(false, addUserViewModel.updateUser("abc", "abc", "  "));
        }

        [Test]
        public void updateUser_8()
        {
            Assert.AreEqual(true, addUserViewModel.updateUser("abc", "abc", "abc"));
        }
    }
}
