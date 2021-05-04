using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cezar_cipher;

namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string expected = "Cnc oc mqvc";
            string actual = CipherCezar.Encipher("Ala ma kota", 2);
            Assert.AreEqual(expected, actual);
        }

        //
        //
    }
}
