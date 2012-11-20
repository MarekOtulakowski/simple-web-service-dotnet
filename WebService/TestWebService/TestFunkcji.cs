using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWebService
{
    [TestClass]
    public class TestFunkcji
    {
        MyWebService.WebServiceSoapClient mws;

        [TestInitialize]
        public void TestInitalize_UtworzenieObiektuKlienta()
        {
            mws = new MyWebService.WebServiceSoapClient();
            Assert.IsNotNull(mws);
        }

        [TestMethod]
        public void Test_Dodaj()
        {
            int wynik = int.Parse((mws.Dodaj(1, 1)).ToString());
            Assert.AreEqual(wynik, 2);
        }

        [TestMethod]
        public void Test_Odejmij()
        {
            int wynik = int.Parse((mws.Odejmij(1, 1)).ToString());
            Assert.AreEqual(wynik, 0);
        }

        [TestMethod]
        public void Test_Pomnoz()
        {
            int wynik = int.Parse((mws.Pomnoz(1, 1)).ToString());
            Assert.AreEqual(wynik, 1);
        }

        [TestMethod]
        public void Test_Podziel()
        {
            int wynik = int.Parse((mws.Podziel(1, 1)).ToString());
            Assert.AreEqual(wynik, 1);
        }

        [TestMethod]
        public void Test_Podziel_Zero()
        {
            bool bWynik = false;
            try
            {
                int wynik = int.Parse((mws.Podziel(1, 0)).ToString());
                bWynik = true;
            }
            catch {}
            Assert.IsFalse(bWynik);
        }

        [TestCleanup]
        public void TestCleanup_UsuniecieObiektuKlienta()
        {
            mws = null;
            Assert.IsNull(mws);
        }
    }
}
