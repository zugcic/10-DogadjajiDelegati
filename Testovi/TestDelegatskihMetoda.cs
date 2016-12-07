using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDelegatskihMetoda : ConsoleTest
    {
        [TestMethod]
        public void StatičkeNestatičkeDelegatskeMetode_PozivDelegataZaStatičkuMetodu()
        {
            StatičkeNestatičkeDelegatskeMetode.PoziviPrekoDelegata();
            Assert.AreEqual("Pozvana je statička metoda", cw.GetString());
        }

        [TestMethod]
        public void StatičkeNestatičkeDelegatskeMetode_PozivDelegataZaNestatičkuMetodu()
        {
            StatičkeNestatičkeDelegatskeMetode.PoziviPrekoDelegata();
            Assert.AreEqual("Pozvana je statička metoda", cw.GetString());
            Assert.AreEqual("Pozvana je statička metoda", cw.GetString());
            Assert.AreEqual("Pozvana je metoda instance", cw.GetString());
        }
    }
}
