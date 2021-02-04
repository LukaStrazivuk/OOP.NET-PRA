using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using QuickType;
using System.Collections;
using Projekt.Jezici;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.WebControls.WebParts;

namespace Projekt
{
    public partial class OdabriIgracaUCWomen : UserControl
    {
        public OdabriIgracaUCWomen()
        {
            InitializeComponent();
            LoadData();
            init();
        }
        private void init()
        {
            listaOmiljenih.AllowDrop = true;
            listaSvih.AllowDrop = true;
            btnDalje.Text = MojiResursi.gumbSpremi;
        }
        private void btnPrebaciDesno_Click(object sender, EventArgs e)
        {
            var selected = listaOmiljenih.SelectedItem;
            if (selected == null)
            {
                return;
            }
            listaOmiljenih.Items.Remove(selected);
            listaSvih.Items.Add(selected);
        }
        private void btnPrebaciLijevo_Click(object sender, EventArgs e)
        {
            var selected = listaSvih.SelectedItem;
            if (selected == null)
            {
                return;
            }
            listaOmiljenih.Items.Add(selected);
            listaSvih.Items.Remove(selected);
        }
        private async void LoadData()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacijaWomen.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country;
            if (parts.Count()==3)
            {
                 country = parts[0] +" " + parts[1];
            }
            else
            {
                country = parts[0];
            }            
            var team = await GetData();
            List<StartingEleven> igraci = new List<StartingEleven>();
            for (int i = 0; i < 12; i++)
            {
                if (team[i].AwayTeamCountry == country)
                {
                    for (int j = 0; j < team[i].AwayTeamStatistics.StartingEleven.Count; j++)
                    {
                        igraci.Add(team[i].AwayTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < team[i].AwayTeamStatistics.Substitutes.Count; j++)
                    {
                        igraci.Add(team[i].AwayTeamStatistics.Substitutes[j]);
                    }
                }
                else if (team[i].HomeTeamCountry == country)
                {
                    for (int j = 0; j < team[i].HomeTeamStatistics.StartingEleven.Count; j++)
                    {
                        igraci.Add(team[i].HomeTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < team[i].HomeTeamStatistics.Substitutes.Count; j++)
                    {
                        igraci.Add(team[i].HomeTeamStatistics.Substitutes[j]);
                    }
                }

            }
            foreach (var igrac in igraci)
            {
                listaSvih.Items.Add(igrac);
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
        private void listaSvih_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                listaOmiljenih.DoDragDrop(listaSvih.SelectedItem.ToString(), DragDropEffects.Copy);

            }
            catch (Exception)
            {
                return;
            }
        }
        private void listaOmiljenih_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void listaOmiljenih_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                return;
            }
            if (listaOmiljenih.Items.Count < 3 && !listaOmiljenih.Items.Contains(e.Data))
            {
                listaOmiljenih.Items.Add(e.Data.GetData(DataFormats.Text));
                listaSvih.Items.Remove(e.Data.GetData(DataFormats.Text));
                listaSvih.ClearSelected();
            }
            else
            {
                return;
            }
        }
        private void btnPrebaciSveDesno_Click(object sender, EventArgs e)
        {
            while (listaOmiljenih.SelectedItems.Count != 0)
            {
                listaSvih.Items.Add(listaOmiljenih.SelectedItems[0]);
                listaOmiljenih.Items.Remove(listaOmiljenih.SelectedItems[0]);
            }
        }
        private void btnPrebaciSveLijevo_Click(object sender, EventArgs e)
        {
            while (listaSvih.SelectedItems.Count != 0)
            {
                listaSvih.Items.Remove(listaSvih.SelectedItems[0]);
                listaOmiljenih.Items.Add(listaOmiljenih.SelectedItems[0]);
            }
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Anamarija/Desktop/OdabraniIgraciWomen.txt";
            StreamWriter SaveFile = new StreamWriter(path);
            foreach (var item in listaOmiljenih.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.ToString();
            SaveFile.Close();
            this.Hide();
        }
    }
}
