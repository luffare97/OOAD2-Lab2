namespace GUI
{
    partial class StartAnnan
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
            this.inloggadNamn = new System.Windows.Forms.Label();
            this.redigeraProfil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMinaListor = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seLista = new System.Windows.Forms.Button();
            this.seAktivitet = new System.Windows.Forms.Button();
            this.loggaUt = new System.Windows.Forms.Button();
            this.InLoggadProgram = new System.Windows.Forms.Label();
            this.inLoggadJobb = new System.Windows.Forms.Label();
            this.inLoggadExamensÅr = new System.Windows.Forms.Label();
            this.inLoggadOrt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinaListor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inloggadNamn
            // 
            this.inloggadNamn.AutoSize = true;
            this.inloggadNamn.Location = new System.Drawing.Point(6, 16);
            this.inloggadNamn.Name = "inloggadNamn";
            this.inloggadNamn.Size = new System.Drawing.Size(93, 13);
            this.inloggadNamn.TabIndex = 0;
            this.inloggadNamn.Text = "Namn på inloggad";
            // 
            // redigeraProfil
            // 
            this.redigeraProfil.Location = new System.Drawing.Point(9, 131);
            this.redigeraProfil.Name = "redigeraProfil";
            this.redigeraProfil.Size = new System.Drawing.Size(113, 23);
            this.redigeraProfil.TabIndex = 3;
            this.redigeraProfil.Text = "Redigera profil";
            this.redigeraProfil.UseVisualStyleBackColor = true;
            this.redigeraProfil.Click += new System.EventHandler(this.redigeraProfil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inLoggadOrt);
            this.groupBox1.Controls.Add(this.inLoggadExamensÅr);
            this.groupBox1.Controls.Add(this.inLoggadJobb);
            this.groupBox1.Controls.Add(this.InLoggadProgram);
            this.groupBox1.Controls.Add(this.loggaUt);
            this.groupBox1.Controls.Add(this.redigeraProfil);
            this.groupBox1.Controls.Add(this.inloggadNamn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seLista);
            this.groupBox2.Controls.Add(this.dataGridViewMinaListor);
            this.groupBox2.Location = new System.Drawing.Point(166, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 338);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mina utskicks listor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seAktivitet);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(428, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 338);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktiviteter";
            // 
            // dataGridViewMinaListor
            // 
            this.dataGridViewMinaListor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinaListor.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewMinaListor.Name = "dataGridViewMinaListor";
            this.dataGridViewMinaListor.Size = new System.Drawing.Size(224, 280);
            this.dataGridViewMinaListor.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(199, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seLista
            // 
            this.seLista.Location = new System.Drawing.Point(15, 305);
            this.seLista.Name = "seLista";
            this.seLista.Size = new System.Drawing.Size(75, 23);
            this.seLista.TabIndex = 2;
            this.seLista.Text = "Välj lista";
            this.seLista.UseVisualStyleBackColor = true;
            // 
            // seAktivitet
            // 
            this.seAktivitet.Location = new System.Drawing.Point(6, 305);
            this.seAktivitet.Name = "seAktivitet";
            this.seAktivitet.Size = new System.Drawing.Size(75, 23);
            this.seAktivitet.TabIndex = 1;
            this.seAktivitet.Text = "Välj aktivitet";
            this.seAktivitet.UseVisualStyleBackColor = true;
            // 
            // loggaUt
            // 
            this.loggaUt.Location = new System.Drawing.Point(9, 160);
            this.loggaUt.Name = "loggaUt";
            this.loggaUt.Size = new System.Drawing.Size(75, 23);
            this.loggaUt.TabIndex = 4;
            this.loggaUt.Text = "Logga ut";
            this.loggaUt.UseVisualStyleBackColor = true;
            // 
            // InLoggadProgram
            // 
            this.InLoggadProgram.AutoSize = true;
            this.InLoggadProgram.Location = new System.Drawing.Point(6, 38);
            this.InLoggadProgram.Name = "InLoggadProgram";
            this.InLoggadProgram.Size = new System.Drawing.Size(46, 13);
            this.InLoggadProgram.TabIndex = 5;
            this.InLoggadProgram.Text = "Program";
            // 
            // inLoggadJobb
            // 
            this.inLoggadJobb.AutoSize = true;
            this.inLoggadJobb.Location = new System.Drawing.Point(6, 60);
            this.inLoggadJobb.Name = "inLoggadJobb";
            this.inLoggadJobb.Size = new System.Drawing.Size(30, 13);
            this.inLoggadJobb.TabIndex = 6;
            this.inLoggadJobb.Text = "Jobb";
            // 
            // inLoggadExamensÅr
            // 
            this.inLoggadExamensÅr.AutoSize = true;
            this.inLoggadExamensÅr.Location = new System.Drawing.Point(6, 82);
            this.inLoggadExamensÅr.Name = "inLoggadExamensÅr";
            this.inLoggadExamensÅr.Size = new System.Drawing.Size(63, 13);
            this.inLoggadExamensÅr.TabIndex = 7;
            this.inLoggadExamensÅr.Text = "Examens År";
            // 
            // inLoggadOrt
            // 
            this.inLoggadOrt.AutoSize = true;
            this.inLoggadOrt.Location = new System.Drawing.Point(6, 104);
            this.inLoggadOrt.Name = "inLoggadOrt";
            this.inLoggadOrt.Size = new System.Drawing.Size(21, 13);
            this.inLoggadOrt.TabIndex = 8;
            this.inLoggadOrt.Text = "Ort";
            // 
            // StartAnnan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartAnnan";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinaListor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inloggadNamn;
        private System.Windows.Forms.Button redigeraProfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewMinaListor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seLista;
        private System.Windows.Forms.Button seAktivitet;
        private System.Windows.Forms.Button loggaUt;
        private System.Windows.Forms.Label InLoggadProgram;
        private System.Windows.Forms.Label inLoggadExamensÅr;
        private System.Windows.Forms.Label inLoggadJobb;
        private System.Windows.Forms.Label inLoggadOrt;
    }
}