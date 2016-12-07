using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestUlančavanjaDelegata : ConsoleTest
    {
        [TestMethod]
        public void UlančavanjeDelegata_UlančavanjeNaKonzoluDajeIspis()
        {
            UlančavanjeDelegata.IspisPoruka("Janko", "Marko");
            Assert.AreEqual("Marko", cw.GetString());
        }
    }
}
