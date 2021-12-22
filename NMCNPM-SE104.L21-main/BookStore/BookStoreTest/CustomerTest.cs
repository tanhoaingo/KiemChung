using NUnit.Framework;
using BookStore.ViewModel;

namespace BookStoreTest
{
    class CustomerTest
    {
        private AddCustomerViewModel addCustomerViewModel;
        [SetUp]
        public void Setup()
        {
            addCustomerViewModel = new AddCustomerViewModel(true);
        }

        [Test]
        public void addCustomer_1()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("  ", "  ", "  "));
        }
        [Test]
        public void addCustomer_2()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("  ", "  ", "abc"));
        }
        [Test]
        public void addCustomer_3()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("  ", "1", "  "));
        }
        [Test]
        public void addCustomer_4()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("  ", "1", "abc"));
        }
        [Test]
        public void addCustomer_5()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("abc", "  ", "  "));
        }
        [Test]
        public void addCustomer_6()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("abc", "  ", "abc"));
        }
        [Test]
        public void addCustomer_7()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("abc", "1", "  "));
        }
        [Test]
        public void addCustomer_8()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("abc", "1", "abc"));
        }
        [Test]
        public void addCustomer_9()
        {
            Assert.AreEqual(false, addCustomerViewModel.addCustomer("1", "abc", "abc"));
        }
        [Test]
        public void addCustomer_10()
        {
            Assert.AreEqual(true, addCustomerViewModel.addCustomer("abc", "abc", "abc"));
        }

        [Test]
        public void updateCustomer_1()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("  ", "  ", "  "));
        }
        [Test]
        public void updateCustomer_2()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("  ", "  ", "abc"));
        }
        [Test]
        public void updateCustomer_3()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("  ", "1", "  "));
        }
        [Test]
        public void updateCustomer_4()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("  ", "1", "abc"));
        }
        [Test]
        public void updateCustomer_5()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("abc", "  ", "  "));
        }
        [Test]
        public void updateCustomer_6()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("abc", "  ", "abc"));
        }
        [Test]
        public void updateCustomer_7()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("abc", "1", "  "));
        }
        [Test]
        public void updateCustomer_8()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("abc", "1", "abc"));
        }
        [Test]
        public void updateCustomer_9()
        {
            Assert.AreEqual(false, addCustomerViewModel.updateCustomer("1", "abc", "abc"));
        }
        [Test]
        public void updateCustomer_10()
        {
            Assert.AreEqual(true, addCustomerViewModel.updateCustomer("abc", "abc", "abc"));
        }
    }
}
