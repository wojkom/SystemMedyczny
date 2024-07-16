namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa abstrakcyjna reprezentująca osobę w systemie medycznym.
    /// </summary>
    public abstract class Osoba : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia numer ubezpieczenia osoby.
        /// </summary>
        /// <value>Numer ubezpieczenia osoby.</value>
        public string NrUbezpieczenia { get; set; }

        /// <summary>
        /// Pobiera lub ustawia imię osoby.
        /// </summary>
        /// <value>Imię osoby.</value>
        public string Imie { get; set; }

        /// <summary>
        /// Pobiera lub ustawia nazwisko osoby.
        /// </summary>
        /// <value>Nazwisko osoby.</value>
        public string Nazwisko { get; set; }

        /// <summary>
        /// Pobiera lub ustawia adres osoby.
        /// </summary>
        /// <value>Adres osoby.</value>
        public string Adres { get; set; }

        /// <summary>
        /// Pobiera lub ustawia datę urodzenia osoby.
        /// </summary>
        /// <value>Data urodzenia osoby.</value>
        public DateTime DataUrodzenia { get; set; }

        /// <summary>
        /// Pobiera wiek osoby, obliczany na podstawie daty urodzenia.
        /// </summary>
        /// <value>Wiek osoby w latach.</value>
        public double Wiek => (DateTime.Now - DataUrodzenia).TotalDays / 365.25;

        /// <summary>
        /// Pobiera imię i nazwisko osoby.
        /// </summary>
        /// <value>Imię i nazwisko osoby.</value>
        public string ImieINazwisko => $"{Imie} {Nazwisko}";
    }
}
