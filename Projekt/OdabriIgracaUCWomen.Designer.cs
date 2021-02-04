namespace Projekt
{
    partial class OdabriIgracaUCWomen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDalje = new System.Windows.Forms.Button();
            this.btnPrebaciSveDesno = new System.Windows.Forms.Button();
            this.btnPrebaciSveLijevo = new System.Windows.Forms.Button();
            this.btnPrebaciLijevo = new System.Windows.Forms.Button();
            this.btnPrebaciDesno = new System.Windows.Forms.Button();
            this.listaSvih = new System.Windows.Forms.ListBox();
            this.listaOmiljenih = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(362, 225);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(94, 29);
            this.btnDalje.TabIndex = 13;
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // btnPrebaciSveDesno
            // 
            this.btnPrebaciSveDesno.Location = new System.Drawing.Point(371, 97);
            this.btnPrebaciSveDesno.Name = "btnPrebaciSveDesno";
            this.btnPrebaciSveDesno.Size = new System.Drawing.Size(75, 54);
            this.btnPrebaciSveDesno.TabIndex = 12;
            this.btnPrebaciSveDesno.Text = ">>";
            this.btnPrebaciSveDesno.UseVisualStyleBackColor = true;
            this.btnPrebaciSveDesno.Click += new System.EventHandler(this.btnPrebaciSveDesno_Click);
            // 
            // btnPrebaciSveLijevo
            // 
            this.btnPrebaciSveLijevo.Location = new System.Drawing.Point(371, 324);
            this.btnPrebaciSveLijevo.Name = "btnPrebaciSveLijevo";
            this.btnPrebaciSveLijevo.Size = new System.Drawing.Size(75, 54);
            this.btnPrebaciSveLijevo.TabIndex = 11;
            this.btnPrebaciSveLijevo.Text = "<<";
            this.btnPrebaciSveLijevo.UseVisualStyleBackColor = true;
            this.btnPrebaciSveLijevo.Click += new System.EventHandler(this.btnPrebaciSveLijevo_Click);
            // 
            // btnPrebaciLijevo
            // 
            this.btnPrebaciLijevo.Location = new System.Drawing.Point(371, 404);
            this.btnPrebaciLijevo.Name = "btnPrebaciLijevo";
            this.btnPrebaciLijevo.Size = new System.Drawing.Size(75, 54);
            this.btnPrebaciLijevo.TabIndex = 10;
            this.btnPrebaciLijevo.Text = "<";
            this.btnPrebaciLijevo.UseVisualStyleBackColor = true;
            this.btnPrebaciLijevo.Click += new System.EventHandler(this.btnPrebaciLijevo_Click);
            // 
            // btnPrebaciDesno
            // 
            this.btnPrebaciDesno.Location = new System.Drawing.Point(371, 21);
            this.btnPrebaciDesno.Name = "btnPrebaciDesno";
            this.btnPrebaciDesno.Size = new System.Drawing.Size(75, 54);
            this.btnPrebaciDesno.TabIndex = 9;
            this.btnPrebaciDesno.Text = ">";
            this.btnPrebaciDesno.UseVisualStyleBackColor = true;
            this.btnPrebaciDesno.Click += new System.EventHandler(this.btnPrebaciDesno_Click);
            // 
            // listaSvih
            // 
            this.listaSvih.AllowDrop = true;
            this.listaSvih.FormattingEnabled = true;
            this.listaSvih.Location = new System.Drawing.Point(483, 4);
            this.listaSvih.Name = "listaSvih";
            this.listaSvih.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listaSvih.Size = new System.Drawing.Size(330, 472);
            this.listaSvih.TabIndex = 8;
            this.listaSvih.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaSvih_MouseDown);
            // 
            // listaOmiljenih
            // 
            this.listaOmiljenih.AllowDrop = true;
            this.listaOmiljenih.FormattingEnabled = true;
            this.listaOmiljenih.Location = new System.Drawing.Point(1, 4);
            this.listaOmiljenih.Name = "listaOmiljenih";
            this.listaOmiljenih.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listaOmiljenih.Size = new System.Drawing.Size(330, 472);
            this.listaOmiljenih.Sorted = true;
            this.listaOmiljenih.TabIndex = 7;
            this.listaOmiljenih.DragDrop += new System.Windows.Forms.DragEventHandler(this.listaOmiljenih_DragDrop);
            this.listaOmiljenih.DragEnter += new System.Windows.Forms.DragEventHandler(this.listaOmiljenih_DragEnter);
            // 
            // OdabriIgracaUCWomen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnPrebaciSveDesno);
            this.Controls.Add(this.btnPrebaciSveLijevo);
            this.Controls.Add(this.btnPrebaciLijevo);
            this.Controls.Add(this.btnPrebaciDesno);
            this.Controls.Add(this.listaSvih);
            this.Controls.Add(this.listaOmiljenih);
            this.Name = "OdabriIgracaUCWomen";
            this.Size = new System.Drawing.Size(815, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Button btnPrebaciSveDesno;
        private System.Windows.Forms.Button btnPrebaciSveLijevo;
        private System.Windows.Forms.Button btnPrebaciLijevo;
        private System.Windows.Forms.Button btnPrebaciDesno;
        private System.Windows.Forms.ListBox listaSvih;
        private System.Windows.Forms.ListBox listaOmiljenih;
    }
}
