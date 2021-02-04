namespace Projekt
{
    partial class RangListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangListe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tsPostavke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPromijeniNaciju = new System.Windows.Forms.ToolStripMenuItem();
            this.promijeniNatjecanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izadiIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbGolovi = new System.Windows.Forms.TextBox();
            this.lbGolovi = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbCaptain = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbIgrac = new System.Windows.Forms.PictureBox();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbIgraci = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.textBoxZuti = new System.Windows.Forms.TextBox();
            this.lbZuti = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxCaptain = new System.Windows.Forms.TextBox();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.textBoxSur = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lbCaptain = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbZutiKartoni = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.lbHomeTeam = new System.Windows.Forms.Label();
            this.tBoxHome = new System.Windows.Forms.TextBox();
            this.tBoxAway = new System.Windows.Forms.TextBox();
            this.tBoxAttendance = new System.Windows.Forms.TextBox();
            this.tBoxVenue = new System.Windows.Forms.TextBox();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.lbAttendance = new System.Windows.Forms.Label();
            this.lbVenue = new System.Windows.Forms.Label();
            this.lbPosjecenost = new System.Windows.Forms.ListBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.menuStrip3);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.tbGolovi);
            this.tabPage1.Controls.Add(this.lbGolovi);
            this.tabPage1.Controls.Add(this.lblBroj);
            this.tabPage1.Controls.Add(this.tbBroj);
            this.tabPage1.Controls.Add(this.tbCaptain);
            this.tabPage1.Controls.Add(this.tbPosition);
            this.tabPage1.Controls.Add(this.tbSurname);
            this.tabPage1.Controls.Add(this.tbName);
            this.tabPage1.Controls.Add(this.pbIgrac);
            this.tabPage1.Controls.Add(this.lblCaptain);
            this.tabPage1.Controls.Add(this.lblPosition);
            this.tabPage1.Controls.Add(this.lblSurname);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lbIgraci);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1065, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Najbolji strijelci";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPostavke});
            this.menuStrip3.Location = new System.Drawing.Point(4, 4);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1057, 30);
            this.menuStrip3.TabIndex = 48;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tsPostavke
            // 
            this.tsPostavke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPromijeniNaciju,
            this.promijeniNatjecanjeToolStripMenuItem1,
            this.izadiIzAplikacijeToolStripMenuItem});
            this.tsPostavke.Name = "tsPostavke";
            this.tsPostavke.Size = new System.Drawing.Size(80, 26);
            this.tsPostavke.Text = "Postavke";
            // 
            // tsPromijeniNaciju
            // 
            this.tsPromijeniNaciju.Name = "tsPromijeniNaciju";
            this.tsPromijeniNaciju.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsPromijeniNaciju.Size = new System.Drawing.Size(290, 26);
            this.tsPromijeniNaciju.Text = "Promijeni naciju i jezik";
            this.tsPromijeniNaciju.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // promijeniNatjecanjeToolStripMenuItem1
            // 
            this.promijeniNatjecanjeToolStripMenuItem1.Name = "promijeniNatjecanjeToolStripMenuItem1";
            this.promijeniNatjecanjeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.promijeniNatjecanjeToolStripMenuItem1.Size = new System.Drawing.Size(290, 26);
            this.promijeniNatjecanjeToolStripMenuItem1.Text = "Promijeni natjecanje";
            this.promijeniNatjecanjeToolStripMenuItem1.Click += new System.EventHandler(this.promijeniNatjecanjeToolStripMenuItem_Click);
            // 
            // izadiIzAplikacijeToolStripMenuItem
            // 
            this.izadiIzAplikacijeToolStripMenuItem.Name = "izadiIzAplikacijeToolStripMenuItem";
            this.izadiIzAplikacijeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.izadiIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.izadiIzAplikacijeToolStripMenuItem.Text = "Izadi iz aplikacije";
            this.izadiIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izađiIzAplikacijeToolStripMenuItem_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(949, 485);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 28);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbGolovi
            // 
            this.tbGolovi.Location = new System.Drawing.Point(464, 444);
            this.tbGolovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGolovi.Name = "tbGolovi";
            this.tbGolovi.Size = new System.Drawing.Size(227, 22);
            this.tbGolovi.TabIndex = 26;
            // 
            // lbGolovi
            // 
            this.lbGolovi.AutoSize = true;
            this.lbGolovi.Location = new System.Drawing.Point(377, 448);
            this.lbGolovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGolovi.Name = "lbGolovi";
            this.lbGolovi.Size = new System.Drawing.Size(46, 17);
            this.lbGolovi.TabIndex = 25;
            this.lbGolovi.Text = "label1";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(377, 202);
            this.lblBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(46, 17);
            this.lblBroj.TabIndex = 24;
            this.lblBroj.Text = "label1";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(464, 198);
            this.tbBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(227, 22);
            this.tbBroj.TabIndex = 23;
            // 
            // tbCaptain
            // 
            this.tbCaptain.Location = new System.Drawing.Point(464, 369);
            this.tbCaptain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCaptain.Name = "tbCaptain";
            this.tbCaptain.Size = new System.Drawing.Size(227, 22);
            this.tbCaptain.TabIndex = 22;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(464, 282);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(227, 22);
            this.tbPosition.TabIndex = 21;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(464, 118);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(227, 22);
            this.tbSurname.TabIndex = 20;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(464, 41);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(227, 22);
            this.tbName.TabIndex = 19;
            // 
            // pbIgrac
            // 
            this.pbIgrac.Image = global::Projekt.Properties.Resources.Webp2;
            this.pbIgrac.InitialImage = null;
            this.pbIgrac.Location = new System.Drawing.Point(743, 44);
            this.pbIgrac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIgrac.Name = "pbIgrac";
            this.pbIgrac.Size = new System.Drawing.Size(307, 283);
            this.pbIgrac.TabIndex = 18;
            this.pbIgrac.TabStop = false;
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(377, 373);
            this.lblCaptain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(46, 17);
            this.lblCaptain.TabIndex = 17;
            this.lblCaptain.Text = "label1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(377, 286);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(46, 17);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "label1";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(377, 122);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(46, 17);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(375, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "label1";
            // 
            // lbIgraci
            // 
            this.lbIgraci.FormattingEnabled = true;
            this.lbIgraci.ItemHeight = 16;
            this.lbIgraci.Location = new System.Drawing.Point(9, 41);
            this.lbIgraci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbIgraci.Name = "lbIgraci";
            this.lbIgraci.Size = new System.Drawing.Size(356, 484);
            this.lbIgraci.TabIndex = 0;
            this.lbIgraci.SelectedIndexChanged += new System.EventHandler(this.lbIgraci_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btnPrint1);
            this.tabPage2.Controls.Add(this.textBoxZuti);
            this.tabPage2.Controls.Add(this.lbZuti);
            this.tabPage2.Controls.Add(this.lbNumber);
            this.tabPage2.Controls.Add(this.textBoxNum);
            this.tabPage2.Controls.Add(this.textBoxCaptain);
            this.tabPage2.Controls.Add(this.textBoxPos);
            this.tabPage2.Controls.Add(this.textBoxSur);
            this.tabPage2.Controls.Add(this.textBoxName);
            this.tabPage2.Controls.Add(this.lbCaptain);
            this.tabPage2.Controls.Add(this.lbPosition);
            this.tabPage2.Controls.Add(this.lbSurname);
            this.tabPage2.Controls.Add(this.lbName);
            this.tabPage2.Controls.Add(this.lbZutiKartoni);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1065, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Žuti kartoni";
            // 
            // btnPrint1
            // 
            this.btnPrint1.Location = new System.Drawing.Point(947, 492);
            this.btnPrint1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(100, 28);
            this.btnPrint1.TabIndex = 40;
            this.btnPrint1.UseVisualStyleBackColor = true;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textBoxZuti
            // 
            this.textBoxZuti.Location = new System.Drawing.Point(745, 448);
            this.textBoxZuti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxZuti.Name = "textBoxZuti";
            this.textBoxZuti.Size = new System.Drawing.Size(227, 22);
            this.textBoxZuti.TabIndex = 39;
            // 
            // lbZuti
            // 
            this.lbZuti.AutoSize = true;
            this.lbZuti.Location = new System.Drawing.Point(659, 452);
            this.lbZuti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbZuti.Name = "lbZuti";
            this.lbZuti.Size = new System.Drawing.Size(46, 17);
            this.lbZuti.TabIndex = 38;
            this.lbZuti.Text = "label1";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(659, 206);
            this.lbNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(46, 17);
            this.lbNumber.TabIndex = 37;
            this.lbNumber.Text = "label1";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(745, 202);
            this.textBoxNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(227, 22);
            this.textBoxNum.TabIndex = 36;
            // 
            // textBoxCaptain
            // 
            this.textBoxCaptain.Location = new System.Drawing.Point(745, 373);
            this.textBoxCaptain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCaptain.Name = "textBoxCaptain";
            this.textBoxCaptain.Size = new System.Drawing.Size(227, 22);
            this.textBoxCaptain.TabIndex = 35;
            // 
            // textBoxPos
            // 
            this.textBoxPos.Location = new System.Drawing.Point(745, 286);
            this.textBoxPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(227, 22);
            this.textBoxPos.TabIndex = 34;
            // 
            // textBoxSur
            // 
            this.textBoxSur.Location = new System.Drawing.Point(745, 122);
            this.textBoxSur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSur.Name = "textBoxSur";
            this.textBoxSur.Size = new System.Drawing.Size(227, 22);
            this.textBoxSur.TabIndex = 33;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(745, 41);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 22);
            this.textBoxName.TabIndex = 32;
            // 
            // lbCaptain
            // 
            this.lbCaptain.AutoSize = true;
            this.lbCaptain.Location = new System.Drawing.Point(659, 377);
            this.lbCaptain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCaptain.Name = "lbCaptain";
            this.lbCaptain.Size = new System.Drawing.Size(46, 17);
            this.lbCaptain.TabIndex = 30;
            this.lbCaptain.Text = "label1";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(659, 289);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(46, 17);
            this.lbPosition.TabIndex = 29;
            this.lbPosition.Text = "label1";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(659, 126);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(46, 17);
            this.lbSurname.TabIndex = 28;
            this.lbSurname.Text = "label1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(659, 44);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 17);
            this.lbName.TabIndex = 27;
            this.lbName.Text = "label1";
            // 
            // lbZutiKartoni
            // 
            this.lbZutiKartoni.FormattingEnabled = true;
            this.lbZutiKartoni.ItemHeight = 16;
            this.lbZutiKartoni.Location = new System.Drawing.Point(13, 9);
            this.lbZutiKartoni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbZutiKartoni.Name = "lbZutiKartoni";
            this.lbZutiKartoni.Size = new System.Drawing.Size(357, 500);
            this.lbZutiKartoni.TabIndex = 0;
            this.lbZutiKartoni.SelectedIndexChanged += new System.EventHandler(this.lbZutiKartoni_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.btnPrint2);
            this.tabPage3.Controls.Add(this.lbHomeTeam);
            this.tabPage3.Controls.Add(this.tBoxHome);
            this.tabPage3.Controls.Add(this.tBoxAway);
            this.tabPage3.Controls.Add(this.tBoxAttendance);
            this.tabPage3.Controls.Add(this.tBoxVenue);
            this.tabPage3.Controls.Add(this.lbAwayTeam);
            this.tabPage3.Controls.Add(this.lbAttendance);
            this.tabPage3.Controls.Add(this.lbVenue);
            this.tabPage3.Controls.Add(this.lbPosjecenost);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1065, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posiječenost";
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(947, 492);
            this.btnPrint2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(100, 28);
            this.btnPrint2.TabIndex = 46;
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbHomeTeam
            // 
            this.lbHomeTeam.AutoSize = true;
            this.lbHomeTeam.Location = new System.Drawing.Point(717, 185);
            this.lbHomeTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHomeTeam.Name = "lbHomeTeam";
            this.lbHomeTeam.Size = new System.Drawing.Size(46, 17);
            this.lbHomeTeam.TabIndex = 45;
            this.lbHomeTeam.Text = "label1";
            // 
            // tBoxHome
            // 
            this.tBoxHome.Location = new System.Drawing.Point(827, 181);
            this.tBoxHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxHome.Name = "tBoxHome";
            this.tBoxHome.Size = new System.Drawing.Size(227, 22);
            this.tBoxHome.TabIndex = 44;
            // 
            // tBoxAway
            // 
            this.tBoxAway.Location = new System.Drawing.Point(827, 244);
            this.tBoxAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxAway.Name = "tBoxAway";
            this.tBoxAway.Size = new System.Drawing.Size(227, 22);
            this.tBoxAway.TabIndex = 43;
            // 
            // tBoxAttendance
            // 
            this.tBoxAttendance.Location = new System.Drawing.Point(827, 117);
            this.tBoxAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxAttendance.Name = "tBoxAttendance";
            this.tBoxAttendance.Size = new System.Drawing.Size(227, 22);
            this.tBoxAttendance.TabIndex = 42;
            // 
            // tBoxVenue
            // 
            this.tBoxVenue.Location = new System.Drawing.Point(827, 50);
            this.tBoxVenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxVenue.Name = "tBoxVenue";
            this.tBoxVenue.Size = new System.Drawing.Size(227, 22);
            this.tBoxVenue.TabIndex = 41;
            // 
            // lbAwayTeam
            // 
            this.lbAwayTeam.AutoSize = true;
            this.lbAwayTeam.Location = new System.Drawing.Point(717, 247);
            this.lbAwayTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(46, 17);
            this.lbAwayTeam.TabIndex = 40;
            this.lbAwayTeam.Text = "label1";
            // 
            // lbAttendance
            // 
            this.lbAttendance.AutoSize = true;
            this.lbAttendance.Location = new System.Drawing.Point(717, 121);
            this.lbAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAttendance.Name = "lbAttendance";
            this.lbAttendance.Size = new System.Drawing.Size(46, 17);
            this.lbAttendance.TabIndex = 39;
            this.lbAttendance.Text = "label1";
            // 
            // lbVenue
            // 
            this.lbVenue.AutoSize = true;
            this.lbVenue.Location = new System.Drawing.Point(717, 54);
            this.lbVenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVenue.Name = "lbVenue";
            this.lbVenue.Size = new System.Drawing.Size(46, 17);
            this.lbVenue.TabIndex = 38;
            this.lbVenue.Text = "label1";
            // 
            // lbPosjecenost
            // 
            this.lbPosjecenost.FormattingEnabled = true;
            this.lbPosjecenost.ItemHeight = 16;
            this.lbPosjecenost.Location = new System.Drawing.Point(12, 7);
            this.lbPosjecenost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPosjecenost.Name = "lbPosjecenost";
            this.lbPosjecenost.Size = new System.Drawing.Size(357, 500);
            this.lbPosjecenost.TabIndex = 1;
            this.lbPosjecenost.SelectedIndexChanged += new System.EventHandler(this.lbPosjecenost_SelectedIndexChanged);
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // RangListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RangListe";
            this.Text = "RangListe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbIgraci;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbCaptain;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbIgrac;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbGolovi;
        private System.Windows.Forms.Label lbGolovi;
        private System.Windows.Forms.ListBox lbZutiKartoni;
        private System.Windows.Forms.TextBox textBoxZuti;
        private System.Windows.Forms.Label lbZuti;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxCaptain;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.TextBox textBoxSur;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lbCaptain;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox lbPosjecenost;
        private System.Windows.Forms.Label lbHomeTeam;
        private System.Windows.Forms.TextBox tBoxHome;
        private System.Windows.Forms.TextBox tBoxAway;
        private System.Windows.Forms.TextBox tBoxAttendance;
        private System.Windows.Forms.TextBox tBoxVenue;
        private System.Windows.Forms.Label lbAwayTeam;
        private System.Windows.Forms.Label lbAttendance;
        private System.Windows.Forms.Label lbVenue;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Button btnPrint1;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tsPostavke;
        private System.Windows.Forms.ToolStripMenuItem tsPromijeniNaciju;
        private System.Windows.Forms.ToolStripMenuItem promijeniNatjecanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izadiIzAplikacijeToolStripMenuItem;
    }
}