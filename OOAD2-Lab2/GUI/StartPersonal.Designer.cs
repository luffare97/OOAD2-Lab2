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
            this.loggaUt = new System.Windows.Forms.Button();
            this.redigeraProfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Aktiviteter = new System.Windows.Forms.GroupBox();
            this.VisaAktivitet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SeLista = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NyLista = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NyAktivitet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Aktiviteter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loggaUt);
            this.groupBox1.Controls.Add(this.redigeraProfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil";
            // 
            // loggaUt
            // 
            this.loggaUt.Location = new System.Drawing.Point(9, 76);
            this.loggaUt.Name = "loggaUt";
            this.loggaUt.Size = new System.Drawing.Size(89, 23);
            this.loggaUt.TabIndex = 3;
            this.loggaUt.Text = "Logga ut";
            this.loggaUt.UseVisualStyleBackColor = true;
            // 
            // redigeraProfil
            // 
            this.redigeraProfil.Location = new System.Drawing.Point(9, 47);
            this.redigeraProfil.Name = "redigeraProfil";
            this.redigeraProfil.Size = new System.Drawing.Size(89, 23);
            this.redigeraProfil.TabIndex = 1;
            this.redigeraProfil.Text = "Redigera profil";
            this.redigeraProfil.UseVisualStyleBackColor = true;
            this.redigeraProfil.Click += new System.EventHandler(this.redigeraProfil_Click);
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
            // Aktiviteter
            // 
            this.Aktiviteter.Controls.Add(this.NyAktivitet);
            this.Aktiviteter.Controls.Add(this.dataGridView2);
            this.Aktiviteter.Controls.Add(this.VisaAktivitet);
            this.Aktiviteter.Location = new System.Drawing.Point(383, 12);
            this.Aktiviteter.Name = "Aktiviteter";
            this.Aktiviteter.Size = new System.Drawing.Size(233, 341);
            this.Aktiviteter.TabIndex = 1;
            this.Aktiviteter.TabStop = false;
            this.Aktiviteter.Text = "Aktiviteter";
            // 
            // VisaAktivitet
            // 
            this.VisaAktivitet.Location = new System.Drawing.Point(6, 305);
            this.VisaAktivitet.Name = "VisaAktivitet";
            this.VisaAktivitet.Size = new System.Drawing.Size(103, 23);
            this.VisaAktivitet.TabIndex = 0;
            this.VisaAktivitet.Text = "Välj aktivitet";
            this.VisaAktivitet.UseVisualStyleBackColor = true;
            this.VisaAktivitet.Click += new System.EventHandler(this.VisaAktiviter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NyLista);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.SeLista);
            this.groupBox2.Location = new System.Drawing.Point(145, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 341);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utskickslistor";
            // 
            // SeLista
            // 
            this.SeLista.Location = new System.Drawing.Point(6, 305);
            this.SeLista.Name = "SeLista";
            this.SeLista.Size = new System.Drawing.Size(92, 23);
            this.SeLista.TabIndex = 0;
            this.SeLista.Text = "Välj utskickslista";
            this.SeLista.UseVisualStyleBackColor = true;
            this.SeLista.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(219, 280);
            this.dataGridView1.TabIndex = 1;
            // 
            // NyLista
            // 
            this.NyLista.Location = new System.Drawing.Point(134, 305);
            this.NyLista.Name = "NyLista";
            this.NyLista.Size = new System.Drawing.Size(92, 23);
            this.NyLista.TabIndex = 2;
            this.NyLista.Text = "Skapa ny lista";
            this.NyLista.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(221, 280);
            this.dataGridView2.TabIndex = 1;
            // 
            // NyAktivitet
            // 
            this.NyAktivitet.Location = new System.Drawing.Point(124, 305);
            this.NyAktivitet.Name = "NyAktivitet";
            this.NyAktivitet.Size = new System.Drawing.Size(103, 23);
            this.NyAktivitet.TabIndex = 2;
            this.NyAktivitet.Text = "Skapa ny aktivitet";
            this.NyAktivitet.UseVisualStyleBackColor = true;
            // 
            // StartPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Aktiviteter);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartPersonal";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Aktiviteter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button redigeraProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Aktiviteter;
        private System.Windows.Forms.Button VisaAktivitet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loggaUt;
        private System.Windows.Forms.Button SeLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button NyLista;
        private System.Windows.Forms.Button NyAktivitet;
    }
}