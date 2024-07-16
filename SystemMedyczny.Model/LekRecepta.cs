namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca powiązanie leku z receptą oraz ilość leku na recepcie.
    /// </summary>
    public class LekRecepta : Encja
    {
        /// <summary>
        /// Pobiera lub ustawia lek przypisany do recepty.
        /// </summary>
        /// <value>Obiekt typu <see cref="Lek"/> reprezentujący lek przypisany do recepty.</value>
        public Lek Lek { get; set; }

        /// <summary>
        /// Pobiera lub ustawia receptę, do której przypisany jest lek.
        /// </summary>
        /// <value>Obiekt typu <see cref="Recepta"/> reprezentujący receptę, do której przypisany jest lek.</value>
        public Recepta Recepta { get; set; }

        /// <summary>
        /// Pobiera lub ustawia ilość leku na recepcie.
        /// </summary>
        /// <value>Ilość leku na recepcie. Domyślnie ustawiona na 1.</value>
        public int Ilosc { get; set; } = 1;
    }
}
