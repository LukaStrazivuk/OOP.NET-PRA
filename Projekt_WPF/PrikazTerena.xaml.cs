using Newtonsoft.Json;
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
    /// Interaction logic for PrikazTerena.xaml
    /// </summary>
    public partial class PrikazTerena : Window
    {
        int rezHeight;
        int rezWidth;
        Team home;
        string away;
        public PrikazTerena(Team homeTeam, string awayTeam)
        {
            InitializeComponent();
            this.Loaded += PrikazTerena_Loaded; 
            LoadData(homeTeam, awayTeam);
            home = homeTeam;
            away = awayTeam;
        }
        private void PrikazTerena_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"../../../../OdabranaRezolucija.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    string[] parts = line.Split(':');
                    rezWidth = int.Parse(parts[0]);
                    rezHeight = int.Parse(parts[1]);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            this.Width = rezWidth;
            this.Height = rezHeight;
            if (rezHeight==0 || rezWidth==0)
            {
                this.Width = 800;
                this.Height = 600;
            }
        }
        private async void LoadData(Team homeTeam, string awayTeam)
        {
            var fixtures = await GetData();
            Fixture utakmica = new Fixture();
            foreach (var fixture in fixtures)
            {
                if (fixture.HomeTeam.Country == homeTeam.Country || fixture.AwayTeam.Country == homeTeam.Country)
                {
                    if (fixture.HomeTeam.Country == awayTeam.ToString() || fixture.AwayTeam.Country == awayTeam.ToString())
                    {
                        utakmica = fixture;
                    }
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Button gk = new Button();
                    gk.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    gk.Height = 45;
                    gk.Background = Brushes.White;
                    gk.Click += btnIgrac_Click;
                    grid.Children.Add(gk);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Button def = new Button();
                    def.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    def.SetValue(Grid.ColumnProperty, 1);
                    def.Height = 45;
                    def.Background = Brushes.White;
                    def.Click += btnIgrac_Click;
                    stackDefHome.Children.Add(def);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Button mid = new Button();
                    mid.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    mid.SetValue(Grid.ColumnProperty, 2);
                    mid.Height = 45;
                    mid.Background = Brushes.White;
                    mid.Click += btnIgrac_Click;
                    stackMidHome.Children.Add(mid);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Button fow = new Button();
                    fow.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    fow.SetValue(Grid.ColumnProperty, 3);
                    fow.Height = 45;
                    fow.Background = Brushes.White;
                    fow.Click += btnIgrac_Click;
                    stackFowHome.Children.Add(fow);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Button gk = new Button();
                    gk.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    gk.Height = 45;
                    gk.Background = Brushes.White;
                    gk.SetValue(Grid.ColumnProperty, 7);
                    gk.Click += btnIgrac_Click;
                    grid.Children.Add(gk);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Button def = new Button();
                    def.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    def.SetValue(Grid.ColumnProperty, 6);
                    def.Height = 45;
                    def.Background = Brushes.White;
                    def.Click += btnIgrac_Click;
                    stackDefAway.Children.Add(def);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Button mid = new Button();
                    mid.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    mid.SetValue(Grid.ColumnProperty, 5);
                    mid.Height = 45;
                    mid.Background = Brushes.White;
                    mid.Click += btnIgrac_Click;
                    stackMidAway.Children.Add(mid);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Button fow = new Button();
                    fow.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    fow.SetValue(Grid.ColumnProperty, 4);
                    fow.Height = 45;
                    fow.Background = Brushes.White;
                    fow.Click += btnIgrac_Click;
                    stackFowAway.Children.Add(fow);
                }
            }
        }
        private void btnIgrac_Click(object sender, RoutedEventArgs e)
        {
            string s = (sender as Button).Content.ToString();
            PrikazIgraca prikaz = new PrikazIgraca(s, home, away);
            prikaz.Show();
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
    

