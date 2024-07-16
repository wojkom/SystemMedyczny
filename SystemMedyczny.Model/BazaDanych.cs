using Microsoft.EntityFrameworkCore;

namespace SystemMedyczny.Model
{
    /// <summary>
    /// Klasa reprezentująca kontekst bazy danych dla systemu medycznego.
    /// </summary>
    public class BazaDanych : DbContext
    {
        /// <summary>
        /// Ścieżka do pliku bazy danych.
        /// </summary>
        private readonly string sciezkaBazyDanych;

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="BazaDanych"/> z opcjonalną ścieżką do pliku bazy danych.
        /// </summary>
        /// <param name="sciezkaBazyDanych">Ścieżka do pliku bazy danych. Domyślnie "system_medyczny.db".</param>
        public BazaDanych(string sciezkaBazyDanych = "system_medyczny.db")
        {
            this.sciezkaBazyDanych = sciezkaBazyDanych;
        }

        /// <summary>
        /// Pobiera lub ustawia zestaw aptek w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="Apteka"/>.</value>
        public DbSet<Apteka> Apteki { get; set; }

        /// <summary>
        /// Pobiera lub ustawia zestaw firm farmaceutycznych w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="FirmaFarmaceutyczna"/>.</value>
        public DbSet<FirmaFarmaceutyczna> FirmyFarmaceutyczne { get; set; }

        /// <summary>
        /// Pobiera lub ustawia zestaw pacjentów w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="Pacjent"/>.</value>
        public DbSet<Pacjent> Pacjenci { get; set; }

        /// <summary>
        /// Pobiera lub ustawia zestaw lekarzy w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="Lekarz"/>.</value>
        public DbSet<Lekarz> Lekarze { get; set; }

        /// <summary>
        /// Pobiera lub ustawia zestaw recept w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="Recepta"/>.</value>
        public DbSet<Recepta> Recepty { get; set; }

        /// <summary>
        /// Pobiera lub ustawia zestaw leków w bazie danych.
        /// </summary>
        /// <value>DbSet obiektów typu <see cref="Lek"/>.</value>
        public DbSet<Lek> Leki { get; set; }

        /// <summary>
        /// Konfiguruje opcje kontekstu bazy danych.
        /// </summary>
        /// <param name="options">Opcje kontekstu bazy danych.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={sciezkaBazyDanych}");
        }

        /// <summary>
        /// Konfiguruje model danych przy użyciu klasy <see cref="ModelBuilder"/>.
        /// </summary>
        /// <param name="builder">Instancja klasy <see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Apteka>().HasQueryFilter(e => !e.Usunieta);
            builder.Entity<FirmaFarmaceutyczna>().HasQueryFilter(e => !e.Usunieta);
            builder.Entity<Pacjent>().HasQueryFilter(e => !e.Usunieta);
            builder.Entity<Lekarz>().HasQueryFilter(e => !e.Usunieta);
            builder.Entity<Recepta>().HasQueryFilter(e => !e.Usunieta);
            builder.Entity<Lek>().HasQueryFilter(e => !e.Usunieta);
        }
    }
}
