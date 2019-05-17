using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson06_nd.caesar.test
{
    [TestClass]
    public class CaesarTests
    {
        [TestMethod]
        public void CaesarTestShouldEncodeAndDecodeString()
        {
            //arrange
            string originalText = "orig test";
            string password = "abc";
            string result = "";
            
            //act
            result = Program.CaesarDecode(Program.CaesarEncode(originalText, password), password);

            //assert
            Assert.AreEqual(originalText, result);
        }
    }
}
