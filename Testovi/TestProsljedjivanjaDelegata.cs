using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestProsljedjivanjaDelegata : ConsoleTest
    {
        [TestMethod]
        public void ProsljedjivanjeDelegata_IspisFunkcijeSinus()
        {
            ProsljedjivanjeDelegata.IspisFunkcijeSinus();
            Assert.AreEqual(12, cw.Count);
            Assert.AreEqual("Ispis funkcije Double Sin(Double):", cw.GetString());
            Assert.AreEqual("x y", cw.GetString());
            Assert.AreEqual("0 0", cw.GetString());
        }

        [TestMethod]
        public void ProsljedjivanjeDelegata_IspisFunkcijeE()
        {
            ProsljedjivanjeDelegata.IspisFunkcijeE();
            Assert.AreEqual(7, cw.Count);
            Assert.AreEqual("Ispis funkcije Double Exp(Double):", cw.GetString());
            Assert.AreEqual("x y", cw.GetString());
            Assert.AreEqual("0 1", cw.GetString());
        }
    }
}
