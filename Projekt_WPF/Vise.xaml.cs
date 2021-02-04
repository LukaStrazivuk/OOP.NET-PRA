using Newtonsoft.Json;
using Projekt_WPF.Jezici;
using QuickType;
using RestSharp;
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

namespace Projekt_WPF
{
    /// <summary>
    /// Interaction logic for Vise.xaml
    /// </summary>
    public partial class Vise : Window
    {
        public Vise(Team team)
        {
            InitializeComponent();
            LoadData(team);
        }
        private async void LoadData(Team team)
        {
            var nations = await GetData();
            Nacije nacija = new Nacije();
            foreach (var drzava in nations)
            {
                if (drzava.Country == team.Country)
                {
                    nacija = drzava;
                }
            }
            Init(nacija);
        }
        private void Init(Nacije nacija)
        {
            lbName.Content = MojiResursi.lblName;
            nazivDrzave.Content = nacija.Country;
            lbKod.Content = MojiResursi.lbKod;
            kodDrzave.Content = nacija.FifaCode;
            lbOdigrani.Content = MojiResursi.lbOdigrani;
            odigraniDrzave.Content = nacija.GamesPlayed;
            lbPobijede.Content = MojiResursi.lbPobjede;
            pobijedeDrzave.Content = nacija.Wins;
            lbGubici.Content = MojiResursi.lbGubici;
            gubiciDrzave.Content = nacija.Losses;
            lbZabijeni.Content = MojiResursi.lbZabijeni;
            zabijeniDrzave.Content = nacija.GoalsFor;
            lbPrimljeni.Content = MojiResursi.lbPrimljeni;
            primljeniDrzave.Content = nacija.GoalsAgainst;
            lbRazlika.Content = MojiResursi.lbRazlika;
            razlikaDrzave.Content = nacija.GoalDifferential;
        }
        private Task<List<Nacije>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/teams/results");
                var result = restClient.Execute<Nacije>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Nacije>>(result.Content);
            });
        }
    }
}
