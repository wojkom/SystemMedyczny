namespace SystemMedyczny.Model.Testy
{
    [TestClass]
    public class LekarzTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Lekarz lekarz = new Lekarz()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Specjalizacja = "Kardiolog",
                DataRozpoczeciaPracy = new DateTime(2010, 1, 1)
            };

            Assert.AreEqual(14, (int)lekarz.LataWyslugi);
        }
    }
}
