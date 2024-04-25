
namespace veljkonrt8020
{
    partial class forma1
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
            this.txtKorisnickoImeAdmin = new System.Windows.Forms.TextBox();
            this.txtLozinkaAdmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKorisnickoImeAdmin
            // 
            this.txtKorisnickoImeAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.txtKorisnickoImeAdmin.Location = new System.Drawing.Point(288, 301);
            this.txtKorisnickoImeAdmin.Name = "txtKorisnickoImeAdmin";
            this.txtKorisnickoImeAdmin.Size = new System.Drawing.Size(217, 20);
            this.txtKorisnickoImeAdmin.TabIndex = 0;
            // 
            // txtLozinkaAdmin
            // 
            this.txtLozinkaAdmin.Location = new System.Drawing.Point(288, 361);
            this.txtLozinkaAdmin.Name = "txtLozinkaAdmin";
            this.txtLozinkaAdmin.PasswordChar = '*';
            this.txtLozinkaAdmin.Size = new System.Drawing.Size(217, 20);
            this.txtLozinkaAdmin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // forma1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::veljkonrt8020.Properties.Resources.HotelFenix;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLozinkaAdmin);
            this.Controls.Add(this.txtKorisnickoImeAdmin);
            this.Name = "forma1";
            this.Text = "forma1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.forma1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorisnickoImeAdmin;
        private System.Windows.Forms.TextBox txtLozinkaAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}