namespace GUI
{
    partial class StartPersonal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.redigeraProfil = new System.Windows.Forms.Button();
            this.Aktiviteter = new System.Windows.Forms.GroupBox();
            this.VisaAktiviter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loggaUt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Aktiviteter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loggaUt);
            this.groupBox1.Controls.Add(this.redigeraProfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "InLoggad profil";
            // 
            // redigeraProfil
            // 
            this.redigeraProfil.Location = new System.Drawing.Point(6, 49);
            this.redigeraProfil.Name = "redigeraProfil";
            this.redigeraProfil.Size = new System.Drawing.Size(111, 23);
            this.redigeraProfil.TabIndex = 1;
            this.redigeraProfil.Text = "Redigera profil";
            this.redigeraProfil.UseVisualStyleBackColor = true;
            // 
            // Aktiviteter
            // 
            this.Aktiviteter.Controls.Add(this.VisaAktiviter);
            this.Aktiviteter.Location = new System.Drawing.Point(162, 12);
            this.Aktiviteter.Name = "Aktiviteter";
            this.Aktiviteter.Size = new System.Drawing.Size(138, 55);
            this.Aktiviteter.TabIndex = 1;
            this.Aktiviteter.TabStop = false;
            this.Aktiviteter.Text = "Aktiviteter";
            // 
            // VisaAktiviter
            // 
            this.VisaAktiviter.Location = new System.Drawing.Point(6, 19);
            this.VisaAktiviter.Name = "VisaAktiviter";
            this.VisaAktiviter.Size = new System.Drawing.Size(117, 23);
            this.VisaAktiviter.TabIndex = 0;
            this.VisaAktiviter.Text = "Se Aktiviteter";
            this.VisaAktiviter.UseVisualStyleBackColor = true;
            this.VisaAktiviter.Click += new System.EventHandler(this.VisaAktiviter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(162, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utskickslistor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Se utskickslistor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // loggaUt
            // 
            this.loggaUt.Location = new System.Drawing.Point(9, 87);
            this.loggaUt.Name = "loggaUt";
            this.loggaUt.Size = new System.Drawing.Size(108, 23);
            this.loggaUt.TabIndex = 3;
            this.loggaUt.Text = "Logga ut";
            this.loggaUt.UseVisualStyleBackColor = true;
            // 
            // StartPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 157);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Aktiviteter);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartPersonal";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Aktiviteter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button redigeraProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Aktiviteter;
        private System.Windows.Forms.Button VisaAktiviter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loggaUt;
        private System.Windows.Forms.Button button1;
    }
}