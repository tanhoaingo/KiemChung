using NUnit.Framework;
using BookStore.ViewModel;

namespace BookStoreTest
{
    class InvoiceTest
    {
        private ListInvoiceViewModel invoiceViewModel;
        [SetUp]
        public void Setup()
        {
            invoiceViewModel = new ListInvoiceViewModel(true);
        }

        [Test]
        public void addInvoice_1()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("  ", "  ", "abc", "  " ,"abc"));
        }
        [Test]
        public void addInvoice_2()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("  ", "  ", "1/1/2021", "  ", "1"));
        }
        [Test]
        public void addInvoice_3()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("  ", "1", "  ", "  ", "  "));
        }
        [Test]
        public void addInvoice_4()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("  ", "1", "abc", "  ", "abc"));
        }
        [Test]
        public void addInvoice_5()
        {
            Assert.AreEqual(true, invoiceViewModel.addInvoice("1", "abc", "1/1/2021", "1", "1"));
        }
        [Test]
        public void addInvoice_6()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("1", "abc", "  ", "1", "  "));
        }
        [Test]
        public void addInvoice_7()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("1", "  ", "abc", "1", "abc"));
        }
        [Test]
        public void addInvoice_8()
        {
            Assert.AreEqual(true, invoiceViewModel.addInvoice("1", "1", "1/1/2021", "1", "1"));
        }
        [Test]
        public void addInvoice_9()
        {
            Assert.AreEqual(true, invoiceViewModel.addInvoice("abc", "1", "  ", "abc", "  "));
        }
        [Test]
        public void addInvoice_10()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("abc", "1", "abc", "abc", "abc"));
        }
        [Test]
        public void addInvoice_11()
        {
            Assert.AreEqual(false, invoiceViewModel.addInvoice("abc", "abc", "1/1/2021", "abc", "1"));
        }
        [Test]
        public void addInvoice_12()
        {
            Assert.AreEqual(true, invoiceViewModel.addInvoice("abc", "abc", "  ", "abc", "  "));
        }

    }
}
