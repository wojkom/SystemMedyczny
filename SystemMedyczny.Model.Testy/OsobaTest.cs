namespace SystemMedyczny.Model.Testy
{
    [TestClass]
    public class OsobaTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Osoba osoba = new Pacjent()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                DataUrodzenia = new DateTime(1980, 1, 1),
                NrUbezpieczenia = "1234567890",
                Adres = "ul. Kwiatowa 1, 00-001 Warszawa"
            };

            Assert.AreEqual("Jan Kowalski", osoba.ImieINazwisko);
            Assert.AreEqual(44, (int)osoba.Wiek);
        }
    }
}
