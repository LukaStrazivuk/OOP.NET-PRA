using Newtonsoft.Json;
using Projekt.Jezici;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Igraci : Form
    {
        List<StartingEleven> igraci = new List<StartingEleven>();
        public Igraci()
        {
            InitializeComponent();
            init();
            LoadData();
        }
        private void init()
        {
            lblName.Text = MojiResursi.lblName;
            lblSurname.Text = MojiResursi.lblSurname;
            lblPosition.Text = MojiResursi.lblPosition;
            lblCaptain.Text = MojiResursi.lblCaptain;
            lblBroj.Text = MojiResursi.lblBroj;
            btnAddPicture.Text = MojiResursi.btnSave;
            btnDalje.Text = MojiResursi.btnDalje;
            lbFavourite.Text = MojiResursi.lbFavourite;            
        }
        private async void LoadData()
        {
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacija.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country = parts[0];
            var team = await GetData();
            for (int i = 0; i < 16; i++)
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
                lbIgraci.Items.Add(igrac);
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
        private void lbIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStar.Text = " ";
            string lines = lbIgraci.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length==5)
            {
                tbName.Text = parts[0];
                tbSurname.Text = parts[1];
                tbBroj.Text = parts[2];
                tbPosition.Text = parts[3];
                tbCaptain.Text = parts[4];
            }
            else if (parts.Length==6)
            {
                tbName.Text = parts[0];
                tbSurname.Text = parts[1] + " " + parts[2];
                tbBroj.Text = parts[3];
                tbPosition.Text = parts[4];
                tbCaptain.Text = parts[5];
            }
            else
            {
                tbName.Text = parts[0];
                tbSurname.Text = "";
                tbBroj.Text = parts[1];
                tbPosition.Text = parts[2];
                tbCaptain.Text = parts[3];
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", lbIgraci.SelectedItem.ToString())))
            {
                pbIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", lbIgraci.SelectedItem.ToString()));
            }
            else
            {
                pbIgrac.Image = Projekt.Properties.Resources.Webp_net_resizeimage;
            }
            string[] linije = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabraniIgraci.txt"));
            if (linije.Contains(lbIgraci.SelectedItem.ToString()))
            {
                lbStar.Text = "★";
            }
        }       
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    tbPicUrl.Text = open.FileName;
                    pbIgrac.Image = new Bitmap(open.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Došlo je do pogreške");
                }
            }
            try
            {
                File.Copy(tbPicUrl.Text, Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", lbIgraci.SelectedItem.ToString()), true);
            }
            catch (Exception)
            {
                return;
            }
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RangListe(igraci).Show();
        }
    }
}
