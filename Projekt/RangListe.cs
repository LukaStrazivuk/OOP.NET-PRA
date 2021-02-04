using Newtonsoft.Json;
using Projekt.Jezici;
using Projekt.Models;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace Projekt
{
    public partial class RangListe : Form
    {
        Dictionary<StartingEleven, int> igracGol = new Dictionary<StartingEleven, int>();
        Dictionary<StartingEleven, int> igracZutiKarton = new Dictionary<StartingEleven, int>();
        public RangListe(List<StartingEleven> lista)
        {
            InitializeComponent();
            List<StartingEleven> igraci = lista;
            LoadData(igraci);
            Init();
        }
        private void Init()
        {
            //Golovi
            lblName.Text = MojiResursi.lblName;
            lblSurname.Text = MojiResursi.lblSurname;
            lblPosition.Text = MojiResursi.lblPosition;
            lblCaptain.Text = MojiResursi.lblCaptain;
            lblBroj.Text = MojiResursi.lblBroj;
            lbGolovi.Text = MojiResursi.lbGolovi;
            btnPrint.Text = MojiResursi.btnPrint;

            //Zuti
            lbName.Text = MojiResursi.lblName;
            lbSurname.Text = MojiResursi.lblSurname;
            lbNumber.Text = MojiResursi.lblBroj;
            lbPosition.Text = MojiResursi.lblPosition;
            lbCaptain.Text = MojiResursi.lblCaptain;
            lblBroj.Text = MojiResursi.lblBroj;
            lbZuti.Text = MojiResursi.lbZuti;
            btnPrint1.Text = MojiResursi.btnPrint;

            //Posjećenost
            lbVenue.Text = MojiResursi.lbVenue;
            lbAttendance.Text = MojiResursi.lbAttendance;
            lbHomeTeam.Text = MojiResursi.lbHomeTeam;
            lbAwayTeam.Text = MojiResursi.lbAwayTeam;
            btnPrint2.Text = MojiResursi.btnPrint;

            //ToolStrip
            tsPostavke.Text = MojiResursi.postavkeToolStripMenuItem;
            tsPromijeniNaciju.Text = MojiResursi.promijeniNacijuToolStripMenuItem;
            promijeniNatjecanjeToolStripMenuItem1.Text = MojiResursi.promijeniNatjecanjeToolStripMenuItem;
            izadiIzAplikacijeToolStripMenuItem.Text = MojiResursi.izadiIzAplikacije;
        }
        private async void LoadData(List<StartingEleven> igraci)
        {
            var team = await GetData();
            int golovi = 0;
            int zuti = 0;

            //GOLOVI
            foreach (var igrac in igraci)
            {
                for (int i = 0; i < team.Count(); i++)
                {
                    for (int j = 0; j < team[i].HomeTeamEvents.Count(); j++)
                    {
                        if (team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (team[i].HomeTeamEvents[j].Player == igrac.Name)
                            {
                                golovi++;
                            }
                        }
                    }
                    for (int j = 0; j < team[i].AwayTeamEvents.Count(); j++)
                    {
                        if (team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (team[i].AwayTeamEvents[j].Player == igrac.Name)
                            {
                                golovi++;
                            }
                        }
                    }
                }
                igracGol.Add(igrac, golovi);
                golovi = 0;
            }
            GetDictionaryGolovi();

            //ZUTI KARTONI
            foreach (var igrac in igraci)
            {
                for (int i = 0; i < team.Count(); i++)
                {
                    for (int j = 0; j < team[i].HomeTeamEvents.Count(); j++)
                    {
                        if (team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || team[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (team[i].HomeTeamEvents[j].Player == igrac.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                    for (int j = 0; j < team[i].AwayTeamEvents.Count(); j++)
                    {
                        if (team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || team[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (team[i].AwayTeamEvents[j].Player == igrac.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                }
                igracZutiKarton.Add(igrac, zuti);
                zuti = 0;
            }
            GetDictionaryZuti();

            //POSJEĆENOST
            List<Posjećenost> posjećenosts = new List<Posjećenost>();
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacija.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country = parts[0];
            foreach (var utakmica in team)
            {
                if (utakmica.HomeTeamCountry == country || utakmica.AwayTeamCountry == country)
                {
                    Posjećenost p = new Posjećenost
                    {
                        attendance = utakmica.Attendance.Value,
                        venue = utakmica.Venue,
                        home_team_country = utakmica.HomeTeamCountry,
                        away_team_country = utakmica.AwayTeamCountry
                    };
                    posjećenosts.Add(p);
                }
            }
            posjećenosts.Sort();
            foreach (var utakmica in posjećenosts)
            {
                lbPosjecenost.Items.Add(utakmica);
            }

        }
        private void GetDictionaryZuti()
        {
            var sortedDict = from entry in igracZutiKarton orderby entry.Value descending select entry;
            foreach (var igrac in sortedDict)
            {
                lbZutiKartoni.Items.Add(igrac);
            }
        }

        private void GetDictionaryGolovi()
        {
            var sortedDict = from entry in igracGol orderby entry.Value descending select entry;
            foreach (var igrac in sortedDict)
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
            string lines = lbIgraci.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = parts[1];
                tbBroj.Text = parts[2];
                tbPosition.Text = parts[3];
                tbCaptain.Text = parts[4].TrimEnd(',');
                tbGolovi.Text = parts[5].TrimEnd(']');
            }
            else if (parts.Length == 7)
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = parts[1] + " " + parts[2];
                tbBroj.Text = parts[3];
                tbPosition.Text = parts[4];
                tbCaptain.Text = parts[5].TrimEnd(',');
                tbGolovi.Text = parts[6].TrimEnd(']');
            }
            else
            {
                tbName.Text = parts[0].TrimStart('[');
                tbSurname.Text = "";
                tbBroj.Text = parts[1];
                tbPosition.Text = parts[2];
                tbCaptain.Text = parts[3].TrimEnd(',');
                tbGolovi.Text = parts[4].TrimEnd(']');
            }
            if (parts.Length == 6)
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3] + " " + parts[4].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename)))
                {
                    pbIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename));
                }
                else
                {
                    pbIgrac.Image = Projekt.Properties.Resources.Webp_net_resizeimage;
                }
            }
            else if (parts.Length == 7)
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3] + " " + parts[4] + " " + parts[5].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename)))
                {
                    pbIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename));
                }
                else
                {
                    pbIgrac.Image = Projekt.Properties.Resources.Webp_net_resizeimage;
                }
            }
            else
            {
                string filename = parts[0].TrimStart('[') + " " + parts[1] + " " + parts[2] + " " + parts[3].TrimEnd(',');
                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename)))
                {
                    pbIgrac.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Slike\", filename));
                }
                else
                {
                    pbIgrac.Image = Projekt.Properties.Resources.Webp_net_resizeimage;
                }
            }

        }
        private void lbZutiKartoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lines = lbZutiKartoni.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSur.Text = parts[1];
                textBoxNum.Text = parts[2];
                textBoxPos.Text = parts[3];
                textBoxCaptain.Text = parts[4].TrimEnd(',');
                textBoxZuti.Text = parts[5].TrimEnd(']');
            }
            else if (parts.Length == 7)
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSur.Text = parts[1] + " " + parts[2];
                textBoxNum.Text = parts[3];
                textBoxPos.Text = parts[4];
                textBoxCaptain.Text = parts[5].TrimEnd(',');
                textBoxZuti.Text = parts[6].TrimEnd(']');
            }
            else
            {
                textBoxName.Text = parts[0].TrimStart('[');
                textBoxSur.Text = "";
                textBoxNum.Text = parts[1];
                textBoxPos.Text = parts[2];
                textBoxCaptain.Text = parts[3].TrimEnd(',');
                textBoxZuti.Text = parts[4].TrimEnd(']');
            }
        }
        private void lbPosjecenost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Posjećenost p = lbPosjecenost.SelectedItem as Posjećenost;
            tBoxVenue.Text = p.venue;
            tBoxAttendance.Text = p.attendance.ToString();
            tBoxHome.Text = p.home_team_country;
            tBoxAway.Text = p.away_team_country;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument.Print();
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToPreview)
            {
                MessageBox.Show("Printanje je gotovo.");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string men = "men";
            new Postavke(men).Show();
            this.Hide();
        }
        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void promijeniNatjecanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }          
    }
}
