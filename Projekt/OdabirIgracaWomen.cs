using Projekt.Jezici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class OdabirIgracaWomen : Form
    {
        public OdabirIgracaWomen()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            btnDalje.Text = MojiResursi.btnDalje;
            var myControl = new Projekt.OdabriIgracaUCWomen();
            panel1.Controls.Add(myControl);
            lblText.Text = MojiResursi.izaberiteNajdrazeIgrace;
        }
        private void btnDalje_Click(object sender, EventArgs e)
        {
            new IgraciWomen().Show();
            this.Hide();
        }
    }
}
