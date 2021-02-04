using Newtonsoft.Json;
using Projekt_WPF.Jezici;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Odabir_nacije_Women : Window
    {
        List<Fixture> lista;
        public Odabir_nacije_Women()
        {
            InitializeComponent();
            LoadData();
            Init();
            cbHome.SelectionChanged += new SelectionChangedEventHandler(OnMyComboBoxChanged);
        }
        private async void LoadData()
        {
            var nations = await GetData();
            lista = nations;
            List<Team> timovi = new List<Team>();
            for (int i = 0; i < 12; i++)
            {
                timovi.Add(nations[i].HomeTeam);
                timovi.Add(nations[i].AwayTeam);
            }
            foreach (var tim in timovi)
            {
                cbHome.Items.Add(tim);
            }
        }
        private Task<List<Fixture>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("http://worldcup.sfg.io/matches");
                var result = restClient.Execute<Fixture>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);
            });
        }
        private void Init()
        {
            btnDalje.Content = MojiResursi.btnDalje;
            btnOdabranaNacija.Content = MojiResursi.lbVise;
        }
        private void OnMyComboBoxChanged(object sender, SelectionChangedEventArgs e)
        {
            cbAway.Items.Clear();
            var nation = cbHome.SelectedValue as Team;
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].HomeTeam.Country == nation.Country)
                {
                    cbAway.Items.Add(lista[i].AwayTeam.Country);
                }
                else if (lista[i].AwayTeam.Country == nation.Country)
                {
                    cbAway.Items.Add(lista[i].HomeTeam.Country);
                }
            }
        }
        private void btnDalje_Click(object sender, RoutedEventArgs e)
        {
            var homeTeam = cbHome.SelectedValue as Team;
            var prikazTerena = new PrikazTerena_Women(homeTeam, cbAway.SelectedItem.ToString());
            this.Visibility = Visibility.Hidden;
            prikazTerena.Show();
        }
        private void btnOdabranaNacija_Click(object sender, RoutedEventArgs e)
        {
            var homeTeam = cbHome.SelectedValue as Team;
            if (homeTeam == null)
            {
                MessageBox.Show("Odaberite naciju");
                return;
            }
            var višeONaciji = new Vise_Women(homeTeam);
            višeONaciji.Show();
        }
    }
}
