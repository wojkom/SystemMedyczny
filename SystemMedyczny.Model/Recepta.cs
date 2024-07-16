namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca receptę w systemie medycznym.
    /// </summary>
    public class Recepta : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia pacjenta, dla którego jest wystawiona recepta.
        /// </summary>
        /// <value>Obiekt typu <see cref="Pacjent"/> reprezentujący pacjenta, dla którego jest wystawiona recepta.</value>
        public Pacjent Pacjent { get; set; }

        /// <summary>
        /// Pobiera lub ustawia lekarza, który wystawił receptę.
        /// </summary>
        /// <value>Obiekt typu <see cref="Lekarz"/> reprezentujący lekarza, który wystawił receptę.</value>
        public Lekarz Lekarz { get; set; }

        /// <summary>
        /// Pobiera lub ustawia datę wystawienia recepty.
        /// </summary>
        /// <value>Data wystawienia recepty. Domyślnie ustawiona na aktualną datę i godzinę.</value>
        public DateTime DataWystawienia { get; set; } = DateTime.Now;

        /// <summary>
        /// Pobiera lub ustawia listę leków przepisanych na recepcie.
        /// </summary>
        /// <value>Lista obiektów typu <see cref="LekRecepta"/> reprezentujących leki przepisane na recepcie.</value>
        public List<LekRecepta> Leki { get; set; }

        /// <summary>
        /// Pobiera tekstową reprezentację leków na recepcie.
        /// </summary>
        /// <value>Tekstowa reprezentacja leków na recepcie w formacie "Nazwa handlowa leku (ilość), ...".</value>
        public string LekiTekst
        {
            get
            {
                if (Leki == null)
                {
                    return string.Empty;
                }

                return string.Join(", ",
                    Leki.Select(l => $"{l.Lek.NazwaHandlowa} ({l.Ilosc})"));
            }
        }
    }
}
