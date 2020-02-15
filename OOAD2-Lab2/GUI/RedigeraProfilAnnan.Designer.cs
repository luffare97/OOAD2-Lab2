namespace GUI
{
    partial class RedigeraProfilAnnan
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
            this.FNamnLabel = new System.Windows.Forms.Label();
            this.EnamnLabel = new System.Windows.Forms.Label();
            this.SparaLösenord = new System.Windows.Forms.Button();
            this.FNamnTxt = new System.Windows.Forms.TextBox();
            this.ENamnTxt = new System.Windows.Forms.TextBox();
            this.GammaltLösenordLabel = new System.Windows.Forms.Label();
            this.Lösenord = new System.Windows.Forms.GroupBox();
            this.NyttLösenordLabel = new System.Windows.Forms.Label();
            this.UpprepaLösenordLabel = new System.Windows.Forms.Label();
            this.GammaltLösenordTxt = new System.Windows.Forms.TextBox();
            this.NyttLösenordTxt = new System.Windows.Forms.TextBox();
            this.UpprepaLösenordTxt = new System.Windows.Forms.TextBox();
            this.JobbLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EMailLabel = new System.Windows.Forms.Label();
            this.TeleNrLabel = new System.Windows.Forms.Label();
            this.OrtLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.EMailTxt = new System.Windows.Forms.TextBox();
            this.TeleNrTxt = new System.Windows.Forms.TextBox();
            this.OrtTxt = new System.Windows.Forms.TextBox();
            this.AdressTxt = new System.Windows.Forms.TextBox();
            this.AnställningTxt = new System.Windows.Forms.TextBox();
            this.SparaInfo = new System.Windows.Forms.Button();
            this.Tillbaka = new System.Windows.Forms.Button();
            this.Lösenord.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNamnLabel
            // 
            this.FNamnLabel.AutoSize = true;
            this.FNamnLabel.Location = new System.Drawing.Point(6, 16);
            this.FNamnLabel.Name = "FNamnLabel";
            this.FNamnLabel.Size = new System.Drawing.Size(51, 13);
            this.FNamnLabel.TabIndex = 0;
            this.FNamnLabel.Text = "Förnamn:";
            // 
            // EnamnLabel
            // 
            this.EnamnLabel.AutoSize = true;
            this.EnamnLabel.Location = new System.Drawing.Point(6, 42);
            this.EnamnLabel.Name = "EnamnLabel";
            this.EnamnLabel.Size = new System.Drawing.Size(61, 13);
            this.EnamnLabel.TabIndex = 1;
            this.EnamnLabel.Text = "Efternamn: ";
            // 
            // SparaLösenord
            // 
            this.SparaLösenord.Location = new System.Drawing.Point(212, 104);
            this.SparaLösenord.Name = "SparaLösenord";
            this.SparaLösenord.Size = new System.Drawing.Size(75, 23);
            this.SparaLösenord.TabIndex = 2;
            this.SparaLösenord.Text = "Spara";
            this.SparaLösenord.UseVisualStyleBackColor = true;
            // 
            // FNamnTxt
            // 
            this.FNamnTxt.Location = new System.Drawing.Point(135, 13);
            this.FNamnTxt.Name = "FNamnTxt";
            this.FNamnTxt.Size = new System.Drawing.Size(152, 20);
            this.FNamnTxt.TabIndex = 3;
            // 
            // ENamnTxt
            // 
            this.ENamnTxt.Location = new System.Drawing.Point(135, 39);
            this.ENamnTxt.Name = "ENamnTxt";
            this.ENamnTxt.Size = new System.Drawing.Size(152, 20);
            this.ENamnTxt.TabIndex = 4;
            // 
            // GammaltLösenordLabel
            // 
            this.GammaltLösenordLabel.AutoSize = true;
            this.GammaltLösenordLabel.Location = new System.Drawing.Point(6, 29);
            this.GammaltLösenordLabel.Name = "GammaltLösenordLabel";
            this.GammaltLösenordLabel.Size = new System.Drawing.Size(94, 13);
            this.GammaltLösenordLabel.TabIndex = 5;
            this.GammaltLösenordLabel.Text = "Gammalt lösenord:";
            this.GammaltLösenordLabel.Click += new System.EventHandler(this.LösenordLabel_Click);
            // 
            // Lösenord
            // 
            this.Lösenord.Controls.Add(this.UpprepaLösenordTxt);
            this.Lösenord.Controls.Add(this.NyttLösenordTxt);
            this.Lösenord.Controls.Add(this.GammaltLösenordTxt);
            this.Lösenord.Controls.Add(this.UpprepaLösenordLabel);
            this.Lösenord.Controls.Add(this.NyttLösenordLabel);
            this.Lösenord.Controls.Add(this.GammaltLösenordLabel);
            this.Lösenord.Controls.Add(this.SparaLösenord);
            this.Lösenord.Location = new System.Drawing.Point(12, 246);
            this.Lösenord.Name = "Lösenord";
            this.Lösenord.Size = new System.Drawing.Size(293, 138);
            this.Lösenord.TabIndex = 6;
            this.Lösenord.TabStop = false;
            this.Lösenord.Text = "Lösenord";
            // 
            // NyttLösenordLabel
            // 
            this.NyttLösenordLabel.AutoSize = true;
            this.NyttLösenordLabel.Location = new System.Drawing.Point(6, 55);
            this.NyttLösenordLabel.Name = "NyttLösenordLabel";
            this.NyttLösenordLabel.Size = new System.Drawing.Size(72, 13);
            this.NyttLösenordLabel.TabIndex = 6;
            this.NyttLösenordLabel.Text = "Nytt lösenord:";
            // 
            // UpprepaLösenordLabel
            // 
            this.UpprepaLösenordLabel.AutoSize = true;
            this.UpprepaLösenordLabel.Location = new System.Drawing.Point(6, 81);
            this.UpprepaLösenordLabel.Name = "UpprepaLösenordLabel";
            this.UpprepaLösenordLabel.Size = new System.Drawing.Size(114, 13);
            this.UpprepaLösenordLabel.TabIndex = 7;
            this.UpprepaLösenordLabel.Text = "Upprepa nytt lösenord:";
            // 
            // GammaltLösenordTxt
            // 
            this.GammaltLösenordTxt.Location = new System.Drawing.Point(139, 26);
            this.GammaltLösenordTxt.Name = "GammaltLösenordTxt";
            this.GammaltLösenordTxt.PasswordChar = '*';
            this.GammaltLösenordTxt.Size = new System.Drawing.Size(148, 20);
            this.GammaltLösenordTxt.TabIndex = 8;
            // 
            // NyttLösenordTxt
            // 
            this.NyttLösenordTxt.Location = new System.Drawing.Point(139, 52);
            this.NyttLösenordTxt.Name = "NyttLösenordTxt";
            this.NyttLösenordTxt.PasswordChar = '*';
            this.NyttLösenordTxt.Size = new System.Drawing.Size(148, 20);
            this.NyttLösenordTxt.TabIndex = 9;
            // 
            // UpprepaLösenordTxt
            // 
            this.UpprepaLösenordTxt.Location = new System.Drawing.Point(139, 78);
            this.UpprepaLösenordTxt.Name = "UpprepaLösenordTxt";
            this.UpprepaLösenordTxt.PasswordChar = '*';
            this.UpprepaLösenordTxt.Size = new System.Drawing.Size(148, 20);
            this.UpprepaLösenordTxt.TabIndex = 10;
            // 
            // JobbLabel
            // 
            this.JobbLabel.AutoSize = true;
            this.JobbLabel.Location = new System.Drawing.Point(6, 172);
            this.JobbLabel.Name = "JobbLabel";
            this.JobbLabel.Size = new System.Drawing.Size(117, 13);
            this.JobbLabel.TabIndex = 7;
            this.JobbLabel.Text = "Nuvarande Anställning:";
            this.JobbLabel.Click += new System.EventHandler(this.JobbLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SparaInfo);
            this.groupBox2.Controls.Add(this.AnställningTxt);
            this.groupBox2.Controls.Add(this.AdressTxt);
            this.groupBox2.Controls.Add(this.OrtTxt);
            this.groupBox2.Controls.Add(this.TeleNrTxt);
            this.groupBox2.Controls.Add(this.EMailTxt);
            this.groupBox2.Controls.Add(this.AdressLabel);
            this.groupBox2.Controls.Add(this.OrtLabel);
            this.groupBox2.Controls.Add(this.TeleNrLabel);
            this.groupBox2.Controls.Add(this.EMailLabel);
            this.groupBox2.Controls.Add(this.FNamnLabel);
            this.groupBox2.Controls.Add(this.JobbLabel);
            this.groupBox2.Controls.Add(this.FNamnTxt);
            this.groupBox2.Controls.Add(this.EnamnLabel);
            this.groupBox2.Controls.Add(this.ENamnTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 228);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personlig information";
            // 
            // EMailLabel
            // 
            this.EMailLabel.AutoSize = true;
            this.EMailLabel.Location = new System.Drawing.Point(6, 68);
            this.EMailLabel.Name = "EMailLabel";
            this.EMailLabel.Size = new System.Drawing.Size(70, 13);
            this.EMailLabel.TabIndex = 8;
            this.EMailLabel.Text = "E-Mailadress:";
            this.EMailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeleNrLabel
            // 
            this.TeleNrLabel.AutoSize = true;
            this.TeleNrLabel.Location = new System.Drawing.Point(6, 94);
            this.TeleNrLabel.Name = "TeleNrLabel";
            this.TeleNrLabel.Size = new System.Drawing.Size(83, 13);
            this.TeleNrLabel.TabIndex = 9;
            this.TeleNrLabel.Text = "Telefonnummer:";
            // 
            // OrtLabel
            // 
            this.OrtLabel.AutoSize = true;
            this.OrtLabel.Location = new System.Drawing.Point(6, 120);
            this.OrtLabel.Name = "OrtLabel";
            this.OrtLabel.Size = new System.Drawing.Size(24, 13);
            this.OrtLabel.TabIndex = 10;
            this.OrtLabel.Text = "Ort:";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(6, 146);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(63, 13);
            this.AdressLabel.TabIndex = 11;
            this.AdressLabel.Text = "Hemadress:";
            // 
            // EMailTxt
            // 
            this.EMailTxt.Location = new System.Drawing.Point(135, 65);
            this.EMailTxt.Name = "EMailTxt";
            this.EMailTxt.Size = new System.Drawing.Size(152, 20);
            this.EMailTxt.TabIndex = 12;
            // 
            // TeleNrTxt
            // 
            this.TeleNrTxt.Location = new System.Drawing.Point(135, 91);
            this.TeleNrTxt.Name = "TeleNrTxt";
            this.TeleNrTxt.Size = new System.Drawing.Size(152, 20);
            this.TeleNrTxt.TabIndex = 13;
            // 
            // OrtTxt
            // 
            this.OrtTxt.Location = new System.Drawing.Point(135, 117);
            this.OrtTxt.Name = "OrtTxt";
            this.OrtTxt.Size = new System.Drawing.Size(152, 20);
            this.OrtTxt.TabIndex = 14;
            // 
            // AdressTxt
            // 
            this.AdressTxt.Location = new System.Drawing.Point(135, 143);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(152, 20);
            this.AdressTxt.TabIndex = 15;
            this.AdressTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AnställningTxt
            // 
            this.AnställningTxt.Location = new System.Drawing.Point(135, 169);
            this.AnställningTxt.Name = "AnställningTxt";
            this.AnställningTxt.Size = new System.Drawing.Size(152, 20);
            this.AnställningTxt.TabIndex = 16;
            // 
            // SparaInfo
            // 
            this.SparaInfo.Location = new System.Drawing.Point(212, 195);
            this.SparaInfo.Name = "SparaInfo";
            this.SparaInfo.Size = new System.Drawing.Size(75, 23);
            this.SparaInfo.TabIndex = 17;
            this.SparaInfo.Text = "Spara";
            this.SparaInfo.UseVisualStyleBackColor = true;
            // 
            // Tillbaka
            // 
            this.Tillbaka.Location = new System.Drawing.Point(224, 390);
            this.Tillbaka.Name = "Tillbaka";
            this.Tillbaka.Size = new System.Drawing.Size(75, 23);
            this.Tillbaka.TabIndex = 11;
            this.Tillbaka.Text = "Tillbaka";
            this.Tillbaka.UseVisualStyleBackColor = true;
            // 
            // RedigeraProfilAnnan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 423);
            this.Controls.Add(this.Tillbaka);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lösenord);
            this.Name = "RedigeraProfilAnnan";
            this.Text = "Redigera profil";
            this.Lösenord.ResumeLayout(false);
            this.Lösenord.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FNamnLabel;
        private System.Windows.Forms.Label EnamnLabel;
        private System.Windows.Forms.Button SparaLösenord;
        private System.Windows.Forms.TextBox FNamnTxt;
        private System.Windows.Forms.TextBox ENamnTxt;
        private System.Windows.Forms.Label GammaltLösenordLabel;
        private System.Windows.Forms.GroupBox Lösenord;
        private System.Windows.Forms.Label NyttLösenordLabel;
        private System.Windows.Forms.TextBox UpprepaLösenordTxt;
        private System.Windows.Forms.TextBox NyttLösenordTxt;
        private System.Windows.Forms.TextBox GammaltLösenordTxt;
        private System.Windows.Forms.Label UpprepaLösenordLabel;
        private System.Windows.Forms.Label JobbLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EMailLabel;
        private System.Windows.Forms.Label TeleNrLabel;
        private System.Windows.Forms.TextBox AnställningTxt;
        private System.Windows.Forms.TextBox AdressTxt;
        private System.Windows.Forms.TextBox OrtTxt;
        private System.Windows.Forms.TextBox TeleNrTxt;
        private System.Windows.Forms.TextBox EMailTxt;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label OrtLabel;
        private System.Windows.Forms.Button SparaInfo;
        private System.Windows.Forms.Button Tillbaka;
    }
}