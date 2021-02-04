namespace Projekt
{
    partial class WorldCup2018Women
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
            this.lblChooseFavouriteNation = new System.Windows.Forms.Label();
            this.ddlNacije = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChooseFavouriteNation
            // 
            this.lblChooseFavouriteNation.AutoSize = true;
            this.lblChooseFavouriteNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChooseFavouriteNation.Location = new System.Drawing.Point(12, 27);
            this.lblChooseFavouriteNation.Name = "lblChooseFavouriteNation";
            this.lblChooseFavouriteNation.Size = new System.Drawing.Size(392, 39);
            this.lblChooseFavouriteNation.TabIndex = 3;
            this.lblChooseFavouriteNation.Text = "Izaberite najdražu naciju";
            // 
            // ddlNacije
            // 
            this.ddlNacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNacije.FormattingEnabled = true;
            this.ddlNacije.Location = new System.Drawing.Point(146, 105);
            this.ddlNacije.Name = "ddlNacije";
            this.ddlNacije.Size = new System.Drawing.Size(121, 21);
            this.ddlNacije.TabIndex = 2;
            this.ddlNacije.SelectedIndexChanged += new System.EventHandler(this.DdlNacije_SelectedIndexChanged);
            // 
            // WorldCup2018Women
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(433, 194);
            this.Controls.Add(this.lblChooseFavouriteNation);
            this.Controls.Add(this.ddlNacije);
            this.Name = "WorldCup2018Women";
            this.Text = "WorldCup2018Women";
            this.Load += new System.EventHandler(this.WorldCup2018Women_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFavouriteNation;
        private System.Windows.Forms.ComboBox ddlNacije;
    }
}