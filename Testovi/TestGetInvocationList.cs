using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestGetInvocationList : ConsoleTest
    {
        [TestMethod]
        public void GetInvocationList_IspisTablicaFunkcijaZasebno()
        {
            GetInvocationList.Funkcija f = Math.Cos;
            f += Math.Sin;

            GetInvocationList.IspišiFunkcijeZasebno(f, 0, Math.PI / 2, 2);
            Assert.AreEqual("Ispis funkcije Double Cos(Double):", cw.GetString());
            Assert.AreEqual("x y", cw.GetString());
            Assert.AreEqual(string.Format("{0} {1}", 0, Math.Cos(0)), cw.GetString());
            Assert.AreEqual(string.Format("{0} {1}", Math.PI / 2, Math.Cos(Math.PI / 2)), cw.GetString());

            Assert.AreEqual("Ispis funkcije Double Sin(Double):", cw.GetString());
            Assert.AreEqual("x y", cw.GetString());
            Assert.AreEqual(string.Format("{0} {1}", 0, Math.Sin(0)), cw.GetString());
            Assert.AreEqual(string.Format("{0} {1}", Math.PI / 2, Math.Sin(Math.PI / 2)), cw.GetString());
        }
    }
}
