namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa abstrakcyjna reprezentująca bazową encję w systemie medycznym.
    /// </summary>
    public abstract class Encja
    {
        /// <summary>
        /// Pobiera lub ustawia unikalny identyfikator encji.
        /// </summary>
        /// <value>Unikalny identyfikator encji.</value>
        public long Id { get; set; }

        /// <summary>
        /// Pobiera lub ustawia datę utworzenia encji.
        /// </summary>
        /// <value>Data utworzenia encji. Domyślnie jest ustawiana na aktualną datę i godzinę.</value>
        public DateTime DataUtworzenia { get; set; } = DateTime.Now;

        /// <summary>
        /// Pobiera lub ustawia dodatkowe uwagi dotyczące encji.
        /// </summary>
        /// <value>Uwagi dotyczące encji.</value>
        public string Uwagi { get; set; }

        /// <summary>
        /// Pobiera lub ustawia wartość wskazującą, czy encja została usunięta.
        /// </summary>
        /// <value>Wartość <c>true</c> jeśli encja została usunięta; w przeciwnym razie <c>false</c>.</value>
        public bool Usunieta { get; set; }
    }
}
