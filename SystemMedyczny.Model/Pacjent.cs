namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca pacjenta w systemie medycznym.
    /// </summary>
    public class Pacjent : Osoba
    {
        /// <summary>
        /// Pobiera lub ustawia lekarza prowadzącego pacjenta.
        /// </summary>
        /// <value>Obiekt typu <see cref="Lekarz"/> reprezentujący lekarza prowadzącego pacjenta.</value>
        public Lekarz Lekarz { get; set; }
    }
}
