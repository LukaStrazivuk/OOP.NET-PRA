namespace Projekt
{
    partial class Igraci
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
            this.lbIgraci = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pbIgrac = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbCaptain = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.tbPicUrl = new System.Windows.Forms.TextBox();
            this.btnDalje = new System.Windows.Forms.Button();
            this.lbFavourite = new System.Windows.Forms.Label();
            this.lbStar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIgraci
            // 
            this.lbIgraci.FormattingEnabled = true;
            this.lbIgraci.Location = new System.Drawing.Point(8, 8);
            this.lbIgraci.Name = "lbIgraci";
            this.lbIgraci.Size = new System.Drawing.Size(270, 433);
            this.lbIgraci.TabIndex = 0;
            this.lbIgraci.SelectedIndexChanged += new System.EventHandler(this.lbIgraci_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(284, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(284, 136);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(35, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "label1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(284, 273);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "label1";
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(284, 340);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(35, 13);
            this.lblCaptain.TabIndex = 4;
            this.lblCaptain.Text = "label1";
            // 
            // pbIgrac
            // 
            this.pbIgrac.Image = global::Projekt.Properties.Resources.Webp2;
            this.pbIgrac.InitialImage = null;
            this.pbIgrac.Location = new System.Drawing.Point(558, 63);
            this.pbIgrac.Name = "pbIgrac";
            this.pbIgrac.Size = new System.Drawing.Size(230, 230);
            this.pbIgrac.TabIndex = 5;
            this.pbIgrac.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(349, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(171, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(349, 133);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(171, 20);
            this.tbSurname.TabIndex = 7;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(349, 270);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(171, 20);
            this.tbPosition.TabIndex = 8;
            // 
            // tbCaptain
            // 
            this.tbCaptain.Location = new System.Drawing.Point(349, 337);
            this.tbCaptain.Name = "tbCaptain";
            this.tbCaptain.Size = new System.Drawing.Size(171, 20);
            this.tbCaptain.TabIndex = 9;
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(349, 198);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(171, 20);
            this.tbBroj.TabIndex = 10;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(284, 201);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(35, 13);
            this.lblBroj.TabIndex = 11;
            this.lblBroj.Text = "label1";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(558, 412);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(227, 29);
            this.btnAddPicture.TabIndex = 12;
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // tbPicUrl
            // 
            this.tbPicUrl.Location = new System.Drawing.Point(558, 337);
            this.tbPicUrl.Name = "tbPicUrl";
            this.tbPicUrl.Size = new System.Drawing.Size(227, 20);
            this.tbPicUrl.TabIndex = 13;
            // 
            // btnDalje
            // 
            this.btnDalje.Location = new System.Drawing.Point(713, 8);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(75, 23);
            this.btnDalje.TabIndex = 14;
            this.btnDalje.UseVisualStyleBackColor = true;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // lbFavourite
            // 
            this.lbFavourite.AutoSize = true;
            this.lbFavourite.Location = new System.Drawing.Point(284, 399);
            this.lbFavourite.Name = "lbFavourite";
            this.lbFavourite.Size = new System.Drawing.Size(0, 13);
            this.lbFavourite.TabIndex = 15;
            // 
            // lbStar
            // 
            this.lbStar.AutoSize = true;
            this.lbStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStar.ForeColor = System.Drawing.Color.Yellow;
            this.lbStar.Location = new System.Drawing.Point(342, 375);
            this.lbStar.Name = "lbStar";
            this.lbStar.Size = new System.Drawing.Size(0, 42);
            this.lbStar.TabIndex = 16;
            // 
            // Igraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStar);
            this.Controls.Add(this.lbFavourite);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.tbPicUrl);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbCaptain);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbIgrac);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbIgraci);
            this.Name = "Igraci";
            this.Text = "Igraci";
            ((System.ComponentModel.ISupportInitialize)(this.pbIgrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIgraci;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pbIgrac;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbCaptain;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.TextBox tbPicUrl;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Label lbFavourite;
        private System.Windows.Forms.Label lbStar;
    }
}