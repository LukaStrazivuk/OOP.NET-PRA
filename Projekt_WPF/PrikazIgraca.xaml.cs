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
    /// Interaction logic for PrikazIgraca.xaml
    /// </summary>
    public partial class PrikazIgraca : Window
    {
        public PrikazIgraca(string s, Team home, string away)
        {
            InitializeComponent();
            Task task = LoadData(s, home, away);
            Init();
        }
        private void Init()
        {
            lbName.Content = MojiResursi.lblName;
            lbNumber.Content = MojiResursi.lblBroj;
            lbPosition.Content = MojiResursi.lblPosition;
            lbGoals.Content = MojiResursi.lbGolovi;
            lbYellows.Content = MojiResursi.lbZuti;
            lbCaptian.Content = MojiResursi.lblCaptain;
        }
        private async Task LoadData(string s,Team home,string away)
        {
            var fixtures = await GetData();
            StartingEleven odabraniIgrac = new StartingEleven();
            Fixture utakmica = new Fixture();
            foreach (var fixture in fixtures)
            {
                if (fixture.HomeTeam.Country == home.Country || fixture.AwayTeam.Country == home.Country)
                {
                    if (fixture.HomeTeam.Country == away.ToString() || fixture.AwayTeam.Country == away.ToString())
                    {
                        utakmica = fixture;
                    }
                }
            }
            foreach (var igrac in utakmica.HomeTeamStatistics.StartingEleven)
            {
                if (igrac.Name==s)
                {
                    odabraniIgrac = igrac;
                }
            }
            foreach (var igrac in utakmica.AwayTeamStatistics.StartingEleven)
            {
                if (igrac.Name == s)
                {
                    odabraniIgrac = igrac;
                }
            }
            int brojGolova = 0;
            int brojZutih = 0;
            foreach (var dogadaj in utakmica.HomeTeamEvents)
            {
                if (dogadaj.TypeOfEvent==TypeOfEvent.Goal || dogadaj.TypeOfEvent==TypeOfEvent.GoalPenalty)
                {
                    if (dogadaj.Player==odabraniIgrac.Name)
                    {
                        brojGolova++;
                    }
                }
                if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                {
                    if (dogadaj.Player == odabraniIgrac.Name)
                    {
                        brojZutih++;
                    }
                }
            }
            foreach (var dogadaj in utakmica.AwayTeamEvents)
            {
                if (dogadaj.TypeOfEvent == TypeOfEvent.Goal || dogadaj.TypeOfEvent == TypeOfEvent.GoalPenalty)
                {
                    if (dogadaj.Player == odabraniIgrac.Name)
                    {
                        brojGolova++;
                    }
                }
                if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                {
                    if (dogadaj.Player == odabraniIgrac.Name)
                    {
                        brojZutih++;
                    }
                }
            }
            igracIme.Content = odabraniIgrac.Name;
            igracBroj.Content = odabraniIgrac.ShirtNumber;
            igracPozicija.Content = odabraniIgrac.Position;
            igracCaptain.Content = odabraniIgrac.Captain;
            igracGol.Content = brojGolova;
            igracZuti.Content = brojZutih;
            string imeIgaraca = odabraniIgrac.ToString();
            string path = @"C:\Users\Anamarija\Desktop\Slike\" + imeIgaraca;
            try
            {
                Uri uri = new Uri(path);
                slikaIgraca.Source = new BitmapImage(uri);
            }
            catch (Exception)
            {
                return;
            }         
        }
        private Task<List<Fixture>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/matches/");
                var result = restClient.Execute<Fixture>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);
            });
        }
    }
}
