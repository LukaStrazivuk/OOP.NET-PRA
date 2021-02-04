using Projekt.Jezici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class PocetnaForma : Form
    {
        private const string HR = "hr", EN = "en";
        public PocetnaForma()
        {
            InitializeComponent();
        }
        private void init()
        {
            if (System.IO.File.ReadAllText(Path.GetFileName("OdabranaKultura.txt")) ==EN)
            {
                PostaviKulturu(EN);
            }
            else
            {
                PostaviKulturu(HR);
            }
        }
        private void pbMusko_Click(object sender, EventArgs e)
        {
            new WorldCup2018().Show();
            this.Hide();
        }
        private void pbZensko_Click(object sender, EventArgs e)
        {
            new WorldCup2018Women().Show();
            this.Hide();
        }
        private void PocetnaForma_Load(object sender, EventArgs e)
        {
        }
        private void PostaviKulturu(string kultura)
        {
            
            try
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);
                foreach (Control control in Controls)
                {
                    var resursi = new ComponentResourceManager(typeof(PocetnaForma));
                    resursi.ApplyResources(control, control.Name, new CultureInfo(kultura));
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);              
                button1.Text = "EN";
            }
            else
            {
                PostaviKulturu(HR);
                button1.Text = "HR";
            }
            ZapisiKulturu();
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\OdabranaKultura.txt"),button1.Text.ToLower());
        }
    }
}
