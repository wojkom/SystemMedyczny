namespace SystemMedyczny.Model.Testy
{
    [TestClass]
    public class ReceptaTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Recepta recepta = new Recepta()
            {
                Leki = new List<LekRecepta>()
                {
                    new LekRecepta()
                                        {
                        Lek = new Lek()
                        {
                            NazwaHandlowa = "Apap",
                        },
                        Ilosc = 2
                    },
                    new LekRecepta()
                    {
                        Lek = new Lek()
                        {
                            NazwaHandlowa = "Ibuprom",
                        },
                        Ilosc = 1
                    }
                }
            };

            Assert.AreEqual("Apap (2), Ibuprom (1)", recepta.LekiTekst);
        }
    }
}
