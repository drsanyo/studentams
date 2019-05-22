using System;
using Lesson08_01.BookStruct;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson08_01.library.test
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void BookLocalIdShouldBeName_Dd()
        {
            // Assign
            Book knyga;
            knyga.Name = "vardas";
            knyga.Id = "1";

            // Act

            // Assert
            Assert.AreEqual("vardas_1", knyga.LocalId);
        }
    }
}
