namespace Projekt
{
    partial class PocetnaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbZensko = new System.Windows.Forms.PictureBox();
            this.pbMusko = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbZensko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusko)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 2;
            // 
            // pbZensko
            // 
            this.pbZensko.Image = global::Projekt.Properties.Resources._1200px_2019_FIFA_Women_s_World_Cup_svg;
            this.pbZensko.Location = new System.Drawing.Point(529, 53);
            this.pbZensko.Name = "pbZensko";
            this.pbZensko.Size = new System.Drawing.Size(259, 328);
            this.pbZensko.TabIndex = 1;
            this.pbZensko.TabStop = false;
            this.pbZensko.Click += new System.EventHandler(this.pbZensko_Click);
            // 
            // pbMusko
            // 
            this.pbMusko.Image = global::Projekt.Properties.Resources._1200px_2018_FIFA_World_Cup_svg;
            this.pbMusko.Location = new System.Drawing.Point(12, 53);
            this.pbMusko.Name = "pbMusko";
            this.pbMusko.Size = new System.Drawing.Size(259, 328);
            this.pbMusko.TabIndex = 0;
            this.pbMusko.TabStop = false;
            this.pbMusko.Click += new System.EventHandler(this.pbMusko_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "HR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbZensko);
            this.Controls.Add(this.pbMusko);
            this.Name = "PocetnaForma";
            this.Text = "Aplikacija";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZensko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMusko;
        private System.Windows.Forms.PictureBox pbZensko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

