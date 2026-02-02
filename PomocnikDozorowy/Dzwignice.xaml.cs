using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PomocnikDozorowy.OknaPomocnicze;

namespace PomocnikDozorowy
{
    /// <summary>
    /// Logika interakcji dla klasy Dzwignice.xaml
    /// </summary>
    public partial class Dzwignice : Window
    {
        public Dzwignice()
        {
            InitializeComponent();
        }

        private void MainMenu_Powrot(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Edycja_Click(object sender, RoutedEventArgs e)
        {
            OknoHaslo oknoHaslo = new OknoHaslo();
            oknoHaslo.Owner = this;
            oknoHaslo.ShowDialog();

            if(oknoHaslo.IsAuthorized)
            {
                //Przyciski na górnym panelu
                Btn_Edycja.IsEnabled = false;
                Btn_Zapisz.IsEnabled = true;
                Btn_Dodaj.IsEnabled = true;
                Btn_Usun.IsEnabled = true;

                //Boxy aktywowane do edycji
                ID_Box.IsEnabled = true;
            }
        }
        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            //Przyciski na górnym panelu
            Btn_Zapisz.IsEnabled = false;
            Btn_Edycja.IsEnabled = true;
            Btn_Dodaj.IsEnabled = false;
            Btn_Usun.IsEnabled = false;

            //Box'y po edycji
            ID_Box.IsEnabled = false;
        }
    }
}
