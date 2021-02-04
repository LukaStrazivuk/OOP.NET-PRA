using Newtonsoft.Json;
using Projekt.Jezici;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Projekt
{
    public partial class WorldCup2018 : Form
    {
        public WorldCup2018()
        {
            InitializeComponent();       
        }
        private void WorldCup2018_Load(object sender, EventArgs e)
        {
             lblChooseFavouriteNation.Text = MojiResursi.izabertiNajdražuNaciju;
             LoadData();             
        }
        private async void LoadData()
        {
            var nations = await GetData();
            List<Team> timovi = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                timovi.Add(nations[i].HomeTeam);
                timovi.Add(nations[i].AwayTeam);
            }
            foreach (var tim in timovi)
            {
                ddlNacije.Items.Add(tim);
            }

        }
        private Task<List<Fixture>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/matches");                     
                var result = restClient.Execute<Fixture>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);
            });
        }
        private void DdlNacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacija.txt");
            string selectedValue = ddlNacije.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
            this.Hide();
            new OdabirIgraca().Show();
        }
    }
}
