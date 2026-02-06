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
using System.IO;
using System.Text.Json;
using PomocnikDozorowy.UTB;

namespace PomocnikDozorowy
{
    /// <summary>
    /// Logika interakcji dla klasy EdycjaSuwnic.xaml
    /// </summary>
    public partial class EdycjaSuwnic : Window
    {
        List<Suwnice> listaSuwnic;
        string sciezkaPliku = "suwnice.json";
        public EdycjaSuwnic()
        {
            InitializeComponent();
            WczytajDaneSuwnic();
        }
        //Wczytywanie ID do Combobox'a
        private void WczytajDaneSuwnic()
        {
            if (File.Exists(sciezkaPliku))
            {
                string json = File.ReadAllText(sciezkaPliku);
                listaSuwnic = JsonSerializer.Deserialize<List<Suwnice>>(json) ?? new List<Suwnice>();

                ID_suwnic.ItemsSource = listaSuwnic.Select(s => s.ID).ToList();
            }
            else
            {
                listaSuwnic= new List<Suwnice>();
            }
        }
        private void Btn_Anuluj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
