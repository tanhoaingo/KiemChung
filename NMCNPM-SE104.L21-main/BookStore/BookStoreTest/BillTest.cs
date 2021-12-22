using NUnit.Framework;
using BookStore.ViewModel;
namespace BookStoreTest
{
    public class BillTest
    {
        private ListBillViewModel billViewModel;
        [SetUp]
        public void Setup()
        {
            billViewModel = new ListBillViewModel(true);
        }

        [Test]
        public void addBill_1()
        {
            Assert.AreEqual(false, billViewModel.addBill("  ", "  ", "  "));
        }
        [Test]
        public void addBill_2()
        {
            Assert.AreEqual(false, billViewModel.addBill("  ", "  ", "1"));
        }
        [Test]
        public void addBill_3()
        {
            Assert.AreEqual(false, billViewModel.addBill("  ", "1", "abc"));
        }
        [Test]
        public void addBill_4()
        {
            Assert.AreEqual(false, billViewModel.addBill("  ", "1", "1"));
        }
        [Test]
        public void addBill_5()
        {
            Assert.AreEqual(true, billViewModel.addBill("1", "  ", "  "));
        }
        [Test]
        public void addBill_6()
        {
            Assert.AreEqual(false, billViewModel.addBill("1", "  ", "1"));
        }
        [Test]
        public void addBill_7()
        {
            Assert.AreEqual(false, billViewModel.addBill("1", "1", "abc"));
        }
        [Test]
        public void addBill_8()
        {
            Assert.AreEqual(true, billViewModel.addBill("1", "1", "1"));
        }
        [Test]
        public void addBill_9()
        {
            Assert.AreEqual(false, billViewModel.addBill("abc", "abc", "  "));
        }
        [Test]
        public void addBill_10()
        {
            Assert.AreEqual(true, billViewModel.addBill("1", "abc", "1"));
        }

    }
}