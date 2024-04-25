namespace veljkonrt8020
{
    partial class FormaAdmin1
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
            this.btnAzurirajGosta = new System.Windows.Forms.Button();
            this.btnAzurirajSobe = new System.Windows.Forms.Button();
            this.btnAzurirajRez = new System.Windows.Forms.Button();
            this.btnAzurirajKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzurirajGosta
            // 
            this.btnAzurirajGosta.Location = new System.Drawing.Point(12, 252);
            this.btnAzurirajGosta.Name = "btnAzurirajGosta";
            this.btnAzurirajGosta.Size = new System.Drawing.Size(141, 64);
            this.btnAzurirajGosta.TabIndex = 0;
            this.btnAzurirajGosta.Text = "Azuriraj Gosta";
            this.btnAzurirajGosta.UseVisualStyleBackColor = true;
            this.btnAzurirajGosta.Click += new System.EventHandler(this.btnAzurirajGosta_Click);
            // 
            // btnAzurirajSobe
            // 
            this.btnAzurirajSobe.Location = new System.Drawing.Point(127, 322);
            this.btnAzurirajSobe.Name = "btnAzurirajSobe";
            this.btnAzurirajSobe.Size = new System.Drawing.Size(141, 64);
            this.btnAzurirajSobe.TabIndex = 1;
            this.btnAzurirajSobe.Text = "Azuriraj Sobe";
            this.btnAzurirajSobe.UseVisualStyleBackColor = true;
            this.btnAzurirajSobe.Click += new System.EventHandler(this.btnAzurirajSobe_Click);
            // 
            // btnAzurirajRez
            // 
            this.btnAzurirajRez.Location = new System.Drawing.Point(647, 252);
            this.btnAzurirajRez.Name = "btnAzurirajRez";
            this.btnAzurirajRez.Size = new System.Drawing.Size(141, 64);
            this.btnAzurirajRez.TabIndex = 2;
            this.btnAzurirajRez.Text = "Azuriraj Rezervacije";
            this.btnAzurirajRez.UseVisualStyleBackColor = true;
            this.btnAzurirajRez.Click += new System.EventHandler(this.btnAzurirajRez_Click);
            // 
            // btnAzurirajKorisnika
            // 
            this.btnAzurirajKorisnika.Location = new System.Drawing.Point(534, 322);
            this.btnAzurirajKorisnika.Name = "btnAzurirajKorisnika";
            this.btnAzurirajKorisnika.Size = new System.Drawing.Size(141, 64);
            this.btnAzurirajKorisnika.TabIndex = 3;
            this.btnAzurirajKorisnika.Text = "Azuriraj Korisnika";
            this.btnAzurirajKorisnika.UseVisualStyleBackColor = true;
            this.btnAzurirajKorisnika.Click += new System.EventHandler(this.btnAzurirajKorisnika_Click);
            // 
            // FormaAdmin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veljkonrt8020.Properties.Resources.HotelFenix;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzurirajKorisnika);
            this.Controls.Add(this.btnAzurirajRez);
            this.Controls.Add(this.btnAzurirajSobe);
            this.Controls.Add(this.btnAzurirajGosta);
            this.Name = "FormaAdmin1";
            this.Text = "FormaAdmin1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormaAdmin1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajGosta;
        private System.Windows.Forms.Button btnAzurirajSobe;
        private System.Windows.Forms.Button btnAzurirajRez;
        private System.Windows.Forms.Button btnAzurirajKorisnika;
    }
}