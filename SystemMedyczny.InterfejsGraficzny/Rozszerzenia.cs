using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace SystemMedyczny.InterfejsGraficzny
{
    public static class Rozszerzenia
    {
        public static async Task ReloadItemsSource(this DataGrid dataGrid)
        {
            await Task.Delay(100);
            var itemsSource = dataGrid.ItemsSource;
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = itemsSource;
        }

        public static ObservableCollection<T> ToObservable<T>(this IEnumerable<T> enumerable)
        {
            return new ObservableCollection<T>(enumerable);
        }
    }
}
