namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca aptekę w systemie medycznym.
    /// </summary>
    public class Apteka : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia nazwę apteki.
        /// </summary>
        /// <value>Nazwa apteki.</value>
        public string Nazwa { get; set; }

        /// <summary>
        /// Pobiera lub ustawia adres apteki.
        /// </summary>
        /// <value>Adres apteki.</value>
        public string Adres { get; set; }

        /// <summary>
        /// Pobiera lub ustawia numer telefonu apteki.
        /// </summary>
        /// <value>Numer telefonu apteki.</value>
        public string Telefon { get; set; }

        /// <summary>
        /// Pobiera lub ustawia listę leków dostępnych w aptece.
        /// </summary>
        /// <value>Lista obiektów typu LekApteka reprezentujących leki dostępne w aptece.</value>
        public List<LekApteka> Leki { get; set; }
    }
}
