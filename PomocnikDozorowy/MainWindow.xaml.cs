using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PomocnikDozorowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Wyświetla informacje o programie.
        /// </summary>
        private void InfoProgr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pomocnik Dozorowy\n" +
                "            Program dzięki któremu możesz trzymać informacje\n" +
                "            o UTB w jednym miejscu!\n\n" +
                "            © 2024 Pomocnik Dozorowy Team v0.0.0", "Informacje o programie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Wyłącza aplikację.
        /// </summary>

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zamykasz program Pomocnik Dozorowy", "Zamykanie programu", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Wyświetla informacje o tym że moduł jest w budowie.
        /// </summary>
        private void dzwignice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Moduł Dźwignice jest w trakcie tworzenia.", "Moduł w budowie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Wyświetla informacje o tym że moduł jest w budowie.
        /// </summary>
        private void wozkiJezdniowe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Moduł Wózki Jezdniowe jest w trakcie tworzenia.", "Moduł w budowie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Wyświetla informacje o tym że moduł jest w budowie.
        /// </summary>
        private void inne_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Moduł Inne jest w trakcie tworzenia.", "Moduł w budowie", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}