using Projekt.Jezici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Projekt
{
    public partial class OdabirIgraca : Form
    {
        public OdabirIgraca()
        {
            InitializeComponent();
            init();
            this.Hide();
        }
        private void init()
        {
            btnDalje.Text = MojiResursi.btnDalje;
            var myControl = new Projekt.OdabirIgracaUserControl();
            panel1.Controls.Add(myControl);
            lblText.Text = MojiResursi.izaberiteNajdrazeIgrace;
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            new Igraci().Show();
            this.Hide();
        }
    }
}
