using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UWPContacts.ViewModels;

namespace UWPContacts.Tests.MSTest
{
    // TODO: Add appropriate tests
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // TODO: Add tests for functionality you add to MainViewModel.
        [TestMethod]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.IsNotNull(vm);
        }
    }
}
