namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca firmę farmaceutyczną w systemie medycznym.
    /// </summary>
    public class FirmaFarmaceutyczna : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia nazwę firmy farmaceutycznej.
        /// </summary>
        /// <value>Nazwa firmy farmaceutycznej.</value>
        public string Nazwa { get; set; }

        /// <summary>
        /// Pobiera lub ustawia numer telefonu firmy farmaceutycznej.
        /// </summary>
        /// <value>Numer telefonu firmy farmaceutycznej.</value>
        public string Telefon { get; set; }
    }
}
