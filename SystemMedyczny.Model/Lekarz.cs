namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca lekarza w systemie medycznym.
    /// </summary>
    public class Lekarz : Osoba
    {
        /// <summary>
        /// Pobiera lub ustawia specjalizację lekarza.
        /// </summary>
        /// <value>Specjalizacja lekarza.</value>
        public string Specjalizacja { get; set; }

        /// <summary>
        /// Pobiera lub ustawia datę rozpoczęcia pracy przez lekarza.
        /// </summary>
        /// <value>Data rozpoczęcia pracy przez lekarza.</value>
        public DateTime DataRozpoczeciaPracy { get; set; }

        /// <summary>
        /// Pobiera liczbę lat wysługi lekarza, obliczaną na podstawie daty rozpoczęcia pracy.
        /// </summary>
        /// <value>Liczba lat wysługi lekarza.</value>
        public double LataWyslugi => (DateTime.Now - DataRozpoczeciaPracy).TotalDays / 365.25;
    }
}
