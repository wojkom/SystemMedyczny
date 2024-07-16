using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SystemMedyczny.Model;

namespace SystemMedyczny.InterfejsGraficzny
{
    public partial class DodajLekDoReceptyWindow : Window
    {
        private readonly Recepta recepta;
        private readonly BazaDanych baza;

        public DodajLekDoReceptyWindow(Recepta recepta, BazaDanych baza)
        {
            this.recepta = recepta;
            this.baza = baza;
            InitializeComponent();
            lekiReceptyTabela.ItemsSource = baza
                .Entry(recepta)
                .Collection(r => r.Leki)
                .Query()
                .ToObservable();
            lekiComboBox.ItemsSource = baza.Leki.ToObservable();
        }

        private async void LekiReceptyTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                LekRecepta lekRecepta = (LekRecepta)e.Row.DataContext;
                lekRecepta.Recepta = recepta;
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await lekiReceptyTabela.ReloadItemsSource();
        }

        private void LekiReceptyTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(lekiReceptyTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private void OznaczJakoUsuniete(IList encje)
        {
            foreach (Encja encja in encje)
            {
                encja.Usunieta = true;
            }
        }
    }
}
