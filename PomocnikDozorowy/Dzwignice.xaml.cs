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
using PomocnikDozorowy.UTB;
using System.Text.Json;
using System.IO;

namespace PomocnikDozorowy
{
    /// <summary>
    /// Logika interakcji dla klasy Dzwignice.xaml
    /// </summary>
    public partial class Dzwignice : Window
    {
        public Dzwignice()
        {
            this.DataContext = new Suwnice();
            InitializeComponent();
            WczytajSuwniceDoComboBox();
        }
        List<Suwnice> listaSwunic;
        string sciezkaPliku = "suwnice.json";

        private void MainMenu_Powrot(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Edycja_Click(object sender, RoutedEventArgs e)
        {
            OknoHaslo oknoHaslo = new OknoHaslo();
            //oknoHaslo.Owner = this;
            oknoHaslo.ShowDialog();

            if(oknoHaslo.IsAuthorized)
            {
                //Przyciski na górnym panelu
                Btn_Edycja.IsEnabled = false;
                //Btn_Zapisz.IsEnabled = true;
                Btn_Dodaj.IsEnabled = true;
                Btn_Usun.IsEnabled = true;

                //Boxy aktywowane do edycji
                ID_Box.IsEnabled = true;
            }
        }
        /*
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
        */

        private void Btn_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            DodajSuwnice dodajSuwnice = new DodajSuwnice();
            dodajSuwnice.Show();
        }

        //Wypełnia odpowiednie TextBoxy danymi z Json
        private void Wybor_ID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Wybor_ID.SelectedItem == null)
                return;

            string? wybraneID = Wybor_ID.SelectedItem.ToString();
            Suwnice? wybranaSuwnica = listaSwunic.FirstOrDefault(s => s.ID == wybraneID);

            if(wybranaSuwnica != null)
            {
                ID_Box.Text = wybranaSuwnica.ID;
                NrFab_Box.Text = wybranaSuwnica.NrFabryczny.ToString();
                RokProd_Box.Text = wybranaSuwnica.RokProdukcji.ToString();
                UdzNom_Box.Text = wybranaSuwnica.UdzwigNominalny;
                Producent_Box.Text = wybranaSuwnica.Producent;
            }
        }
        //Wczytuje dane z Json do ComboBox'a
        private void WczytajSuwniceDoComboBox()
        {
            if (File.Exists(sciezkaPliku))
            {
                string json = File.ReadAllText(sciezkaPliku);
                listaSwunic = JsonSerializer.Deserialize<List<Suwnice>>(json) ?? new List<Suwnice>();

                Wybor_ID.ItemsSource = listaSwunic.Select(s => s.ID).ToList();
            }
            else
            {
                listaSwunic = new List<Suwnice>();
            }

        }
    }
}
