using NUnit.Framework;
using BookStore.ViewModel;

namespace BookStoreTest
{
    class BookTest
    {
        private AddBookViewModel addBookViewModel;
        [SetUp]
        public void Setup()
        {
            addBookViewModel = new AddBookViewModel(true);
        }

        [Test]
        public void addBook_1()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("  ", "  ", "  "));
        }
        [Test]
        public void addBook_2()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("  ", "  ", "1"));
        }
        [Test]
        public void addBook_3()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("  ", "1", "  "));
        }
        [Test]
        public void addBook_4()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("  ", "1", "1"));
        }
        [Test]
        public void addBook_5()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("abc", "  ", "  "));
        }
        [Test]
        public void addBook_6()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("abc", "  ", "1"));
        }
        [Test]
        public void addBook_7()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("abc", "1", "  "));
        }
        [Test]
        public void addBook_8()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("abc", "1", "1"));
        }
        [Test]
        public void addBook_9()
        {
            Assert.AreEqual(false, addBookViewModel.addBook("1", "abc", "abc"));
        }
        [Test]
        public void addBook_10()
        {
            Assert.AreEqual(true, addBookViewModel.addBook("abc", "abc", "1"));
        }

        [Test]
        public void updateBook_1()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("  ", "  ", "  "));
        }
        [Test]
        public void updateBook_2()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("  ", "  ", "1"));
        }
        [Test]
        public void updateBook_3()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("  ", "1", "  "));
        }
        [Test]
        public void updateBook_4()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("  ", "1", "1"));
        }
        [Test]
        public void updateBook_5()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("abc", "  ", "  "));
        }
        [Test]
        public void updateBook_6()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("abc", "  ", "1"));
        }
        [Test]
        public void updateBook_7()
        {
            Assert.AreEqual(true, addBookViewModel.updateBook("abc", "1", "  "));
        }
        [Test]
        public void updateBook_8()
        {
            Assert.AreEqual(true, addBookViewModel.updateBook("abc", "1", "1"));
        }
        [Test]
        public void updateBook_9()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("1", "abc", "abc"));
        }
        [Test]
        public void updateBook_10()
        {
            Assert.AreEqual(false, addBookViewModel.updateBook("abc", "abc", "1"));
        }
    }
}
