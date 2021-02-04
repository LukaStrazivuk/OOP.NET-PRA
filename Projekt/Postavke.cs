using Newtonsoft.Json;
using Projekt.Jezici;
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Projekt
{
    public partial class Postavke : Form
    {
        private const string HR = "hr", EN = "en";
        bool odabir;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                this.Close();
                new OdabirIgraca().Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public Postavke(string s)
        {
            if (s=="women")
            {
                odabir = false;
            }
            InitializeComponent();
            Init();
            LoadData(s);
        }
        private void Init()
        {
            label1.Text = MojiResursi.izabertiNajdražuNaciju;
            button1.Text = MojiResursi.btnDalje;
            button2.Text = MojiResursi.promijeniJezikToolStripMenuItem;
        }
        private async void LoadData(string s)
        {
            var nations = await GetData(s);
            List<Team> timovi = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                timovi.Add(nations[i].HomeTeam);
                timovi.Add(nations[i].AwayTeam);
            }
            foreach (var tim in timovi)
            {
                cbNacije.Items.Add(tim);
            }
        }
        private Task<List<Fixture>> GetData(string s)
        {
            return Task.Run(() =>
            {
                RestClient restClient;
                if (odabir==false)
                {
                     restClient = new RestClient("https://worldcup.sfg.io/matches");
                }
                else
                {
                     restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/matches");
                }
                var result = restClient.Execute<Fixture>(new RestRequest());
                return JsonConvert.DeserializeObject<List<Fixture>>(result.Content);
            });
        }
        private void CbNacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path;
            if (odabir==false)
            {
                path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacijaWomen.txt");
            }
            else
            {
                path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaNacija.txt");
            }    
            string selectedValue = cbNacije.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);;
            this.Hide();
            new OdabirIgraca().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Sure", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                if (odabir==false)
                {
                    new OdabirIgracaWomen().Show();
                    this.Hide();
                }
                else if (odabir==true)
                {
                    new OdabirIgraca().Show();
                    this.Hide();
                }
            }
            else
            {
                return;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                button2.Text = MojiResursi.promijeniJezikToolStripMenuItem;
            }
            else
            {
                PostaviKulturu(HR);
                button2.Text = MojiResursi.promijeniJezikToolStripMenuItem;
            }
            ZapisiKulturu();
        }
        private void PostaviKulturu(string kultura)
        {           
            try
            {
                //postavi lokalizaciju = prevodi
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                //postavi globalizaciju = datum,vrijeme,valute
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);

                foreach (Control control in Controls)
                {
                    var resursi = new ComponentResourceManager(typeof(PocetnaForma));
                    resursi.ApplyResources(control, control.Name, new CultureInfo(kultura));
                }

                label1.Text = MojiResursi.izaberiPrvenstvo;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaKultura.txt"), button2.Text.ToLower());
        }
    }
}

