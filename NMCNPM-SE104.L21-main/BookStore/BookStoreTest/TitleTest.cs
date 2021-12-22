using NUnit.Framework;
using BookStore.ViewModel;

namespace BookStoreTest
{
    class TitleTest
    {
        private AddBookViewModel addBookViewModel;
        [SetUp]
        public void Setup()
        {
            addBookViewModel = new AddBookViewModel(true);
        }

        [Test]
        public void addTitle_1()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("  ", "  ", "  "));
        }

        [Test]
        public void addTitle_2()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("  ", "  ", "abc"));
        }

        [Test]
        public void addTitle_3()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("  ", "abc", "  "));
        }

        [Test]
        public void addTitle_4()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("  ", "abc", "abc"));
        }

        [Test]
        public void addTitle_5()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("abc", "  ", "  "));
        }

        [Test]
        public void addTitle_6()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("abc", "  ", "abc"));
        }

        [Test]
        public void addTitle_7()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("abc", "abc", "  "));
        }

        [Test]
        public void addTitle_8()
        {
            Assert.AreEqual(false, addBookViewModel.addTitle("abc", "abc", "abc"));
        }

        [Test]
        public void updateTitle_1()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("  ", "  ", "  "));
        }

        [Test]
        public void updateTitle_2()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("  ", "  ", "abc"));
        }

        [Test]
        public void updateTitle_3()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("  ", "abc", "  "));
        }

        [Test]
        public void updateTitle_4()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("  ", "abc", "abc"));
        }

        [Test]
        public void updateTitle_5()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("abc", "  ", "  "));
        }

        [Test]
        public void updateTitle_6()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("abc", "  ", "abc"));
        }

        [Test]
        public void updateTitle_7()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("abc", "abc", "  "));
        }

        [Test]
        public void updateTitle_8()
        {
            Assert.AreEqual(false, addBookViewModel.updateTitle("abc", "abc", "abc"));
        }
    }
}
