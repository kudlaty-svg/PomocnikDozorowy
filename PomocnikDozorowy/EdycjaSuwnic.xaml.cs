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

        private void ID_suwnic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ID_suwnic.SelectedItem == null)
                return;

            string? wybraneID = ID_suwnic.SelectedItem.ToString();
            Suwnice? wybranaSuwnica = listaSuwnic.FirstOrDefault(s => s.ID == wybraneID);

            if(wybranaSuwnica != null)
            {
                Stare_ID.Text = wybranaSuwnica.ID;
            }

        }

        private void Btn_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Suwnice suwnica = new Suwnice();
            /*if (string.IsNullOrEmpty(Nowe_ID.Text))
            {
                MessageBox.Show("Pole [Nowe ID Dźwignicy] nie może być puste!");
                return;
            }*/

            if (!File.Exists(sciezkaPliku))
            {
                MessageBox.Show("Brak pliku danych!");
                return;
            }

            string json = File.ReadAllText(sciezkaPliku);
            listaSuwnic = JsonSerializer.Deserialize<List<Suwnice>>(json) ?? new List<Suwnice>();

            //szukanie suwnicy do edycji
            Suwnice? edytowana = listaSuwnic.FirstOrDefault(s => s.ID == Stare_ID.Text);

            if (edytowana == null)
            {
                MessageBox.Show("Nie znaleziono suwnicy do edycji!");
                return;
            }

            edytowana.ID = Nowe_ID.Text;

            string jsonZapis = JsonSerializer.Serialize(listaSuwnic, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(sciezkaPliku, jsonZapis);

            MessageBox.Show("Dane suwnicy zostały zaktualizowane!");
            this.Close();
        }
    }
}
