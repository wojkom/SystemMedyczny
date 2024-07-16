using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SystemMedyczny.Model;

namespace SystemMedyczny.InterfejsGraficzny
{
    public partial class MainWindow : Window
    {
        private readonly BazaDanych baza;

        public MainWindow()
        {
            InitializeComponent();
            baza = new BazaDanych("../../../../SystemMedyczny.Model/system_medyczny.db");
            pacjenciTabela.ItemsSource = baza.Pacjenci.ToObservable();
            lekarzeTabela.ItemsSource = baza.Lekarze.ToObservable();
            lekiTabela.ItemsSource = baza.Leki.ToObservable();
            firmyFarmaceutyczneTabela.ItemsSource = baza.FirmyFarmaceutyczne.ToObservable();
            aptekiTabela.ItemsSource = baza.Apteki.ToObservable();
            receptyTabela.ItemsSource = baza.Recepty.Include(r => r.Leki).ToObservable();

            lekarzPacjentaKolumna.ItemsSource = lekarzeTabela.ItemsSource;
            firmaFarmaceutycznaKolumna.ItemsSource = firmyFarmaceutyczneTabela.ItemsSource;
            lekarzReceptyKolumna.ItemsSource = lekarzeTabela.ItemsSource;
            pacjentReceptyKolumna.ItemsSource = pacjenciTabela.ItemsSource;

            receptyTabela.ContextMenu.Opened += MenuKontekstoweOpened;
        }

        private async void PacjenciTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await pacjenciTabela.ReloadItemsSource();
        }

        private void PacjenciTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(pacjenciTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private async void LekarzeTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await lekarzeTabela.ReloadItemsSource();
        }

        private void LekarzeTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(lekarzeTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private async void LekiTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await lekiTabela.ReloadItemsSource();
        }

        private void LekiTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(lekiTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private async void FirmyFarmaceutyczneTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await firmyFarmaceutyczneTabela.ReloadItemsSource();
        }

        private void FirmyFarmaceutyczneTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(firmyFarmaceutyczneTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private async void AptekiTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        { 
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await aptekiTabela.ReloadItemsSource();
        }

        private void AptekiTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(aptekiTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private async void ReceptyTabelaRowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (baza.Entry(e.Row.DataContext).State == EntityState.Detached)
            {
                baza.Add(e.Row.DataContext);
            }
            baza.SaveChanges();
            await receptyTabela.ReloadItemsSource();
        }

        private void ReceptyTabelaPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                OznaczJakoUsuniete(receptyTabela.SelectedItems);
                baza.SaveChanges();
            }
        }

        private void MenuKontekstoweOpened(object sender, RoutedEventArgs e)
        {
            Recepta recepta = receptyTabela.SelectedItem as Recepta;

            if (recepta == null || recepta.Id == 0)
            {
                dodajLekDoReceptyItem.IsEnabled = false;
            }
            else
            {
                dodajLekDoReceptyItem.IsEnabled = true;
            }
        }

        private void DodajLekDoReceptyClick(object sender, RoutedEventArgs e)
        {
            DodajLekDoReceptyWindow okno = new DodajLekDoReceptyWindow(
                receptyTabela.SelectedItem as Recepta, baza);

            okno.ShowDialog();
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