namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca powiązanie leku z apteką oraz cenę leku w danej aptece.
    /// </summary>
    public class LekApteka : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia lek dostępny w aptece.
        /// </summary>
        /// <value>Obiekt typu <see cref="Lek"/> reprezentujący lek dostępny w aptece.</value>
        public Lek Lek { get; set; }

        /// <summary>
        /// Pobiera lub ustawia aptekę, w której lek jest dostępny.
        /// </summary>
        /// <value>Obiekt typu <see cref="Apteka"/> reprezentujący aptekę, w której lek jest dostępny.</value>
        public Apteka Apteka { get; set; }

        /// <summary>
        /// Pobiera lub ustawia cenę leku w aptece.
        /// </summary>
        /// <value>Cena leku w aptece.</value>
        public decimal Cena { get; set; }
    }
}
