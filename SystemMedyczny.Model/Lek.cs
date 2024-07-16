namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca lek w systemie medycznym.
    /// </summary>
    public class Lek : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia nazwę handlową leku.
        /// </summary>
        /// <value>Nazwa handlowa leku.</value>
        public string NazwaHandlowa { get; set; }

        /// <summary>
        /// Pobiera lub ustawia substancję aktywną leku.
        /// </summary>
        /// <value>Substancja aktywna leku.</value>
        public string SubstancjaAktywna { get; set; }

        /// <summary>
        /// Pobiera lub ustawia firmę farmaceutyczną produkującą lek.
        /// </summary>
        /// <value>Obiekt typu <see cref="FirmaFarmaceutyczna"/> reprezentujący firmę farmaceutyczną produkującą lek.</value>
        public FirmaFarmaceutyczna FirmaFarmaceutyczna { get; set; }
    }
}
