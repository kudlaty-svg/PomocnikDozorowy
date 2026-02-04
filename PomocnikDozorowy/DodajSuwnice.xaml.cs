using PomocnikDozorowy.UTB;
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
using System.Text.Json;
using System.IO;

namespace PomocnikDozorowy
{
    /// <summary>
    /// Logika interakcji dla klasy DodajSuwnice.xaml
    /// </summary>
    public partial class DodajSuwnice : Window
    {
        public DodajSuwnice()
        {
            InitializeComponent();
        }
        List<Suwnice> listaSuwnic;
        string sciezkaPliku = "suwnice.json";
        private void Btn_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            Suwnice suwnica = new Suwnice();

            if(string.IsNullOrEmpty(Tb_ID.Text))
            {
                MessageBox.Show("To pole nie może być puste!");
                return;
            }
            suwnica.ID = Tb_ID.Text;
            if (int.TryParse(Tb_NrFabryczny.Text, out int NrFab)) //Konwertowanie int!
                suwnica.NrFabryczny = NrFab;
            if (int.TryParse(Tb_RokProdukcji.Text, out int RokProd))
                suwnica.RokProdukcji = RokProd;
            suwnica.UdzwigNominalny = Tb_UdzwigNominalny.Text;
            suwnica.Producent = Tb_Producent.Text;

            if(File.Exists(sciezkaPliku))
            {
                string json = File.ReadAllText(sciezkaPliku);
                listaSuwnic = JsonSerializer.Deserialize<List<Suwnice>>(json) ?? new List<Suwnice>();
            }
            else
            {
                listaSuwnic = new List<Suwnice>();
            }
            listaSuwnic.Add(suwnica);

            string jsonZapis = JsonSerializer.Serialize(listaSuwnic, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(sciezkaPliku, jsonZapis);

            MessageBox.Show("Dźwignica zapisana!");
            this.Close();
            
        }
    }
}
