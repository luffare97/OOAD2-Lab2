namespace GUI
{
    partial class NyAktivitet
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TitelLabel = new System.Windows.Forms.Label();
            this.TitelTxt = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AntalPlatserLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.SlutDateLabel = new System.Windows.Forms.Label();
            this.PlatsLabel = new System.Windows.Forms.Label();
            this.Platstxt = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BeskrivningLabel = new System.Windows.Forms.Label();
            this.Spara = new System.Windows.Forms.Button();
            this.Tillbaka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // TitelLabel
            // 
            this.TitelLabel.AutoSize = true;
            this.TitelLabel.Location = new System.Drawing.Point(12, 15);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(100, 13);
            this.TitelLabel.TabIndex = 2;
            this.TitelLabel.Text = "Titel på aktiviteten: ";
            this.TitelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitelTxt
            // 
            this.TitelTxt.Location = new System.Drawing.Point(118, 12);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(200, 20);
            this.TitelTxt.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // AntalPlatserLabel
            // 
            this.AntalPlatserLabel.AutoSize = true;
            this.AntalPlatserLabel.Location = new System.Drawing.Point(12, 40);
            this.AntalPlatserLabel.Name = "AntalPlatserLabel";
            this.AntalPlatserLabel.Size = new System.Drawing.Size(68, 13);
            this.AntalPlatserLabel.TabIndex = 5;
            this.AntalPlatserLabel.Text = "Antal platser:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(12, 70);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(46, 13);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "Start tid:";
            // 
            // SlutDateLabel
            // 
            this.SlutDateLabel.AutoSize = true;
            this.SlutDateLabel.Location = new System.Drawing.Point(12, 96);
            this.SlutDateLabel.Name = "SlutDateLabel";
            this.SlutDateLabel.Size = new System.Drawing.Size(42, 13);
            this.SlutDateLabel.TabIndex = 7;
            this.SlutDateLabel.Text = "Slut tid:";
            // 
            // PlatsLabel
            // 
            this.PlatsLabel.AutoSize = true;
            this.PlatsLabel.Location = new System.Drawing.Point(12, 119);
            this.PlatsLabel.Name = "PlatsLabel";
            this.PlatsLabel.Size = new System.Drawing.Size(33, 13);
            this.PlatsLabel.TabIndex = 8;
            this.PlatsLabel.Text = "Plats:";
            // 
            // Platstxt
            // 
            this.Platstxt.Location = new System.Drawing.Point(118, 116);
            this.Platstxt.Name = "Platstxt";
            this.Platstxt.Size = new System.Drawing.Size(200, 20);
            this.Platstxt.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(118, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 144);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // BeskrivningLabel
            // 
            this.BeskrivningLabel.AutoSize = true;
            this.BeskrivningLabel.Location = new System.Drawing.Point(12, 145);
            this.BeskrivningLabel.Name = "BeskrivningLabel";
            this.BeskrivningLabel.Size = new System.Drawing.Size(65, 13);
            this.BeskrivningLabel.TabIndex = 11;
            this.BeskrivningLabel.Text = "Beskrivning:";
            // 
            // Spara
            // 
            this.Spara.Location = new System.Drawing.Point(243, 292);
            this.Spara.Name = "Spara";
            this.Spara.Size = new System.Drawing.Size(75, 23);
            this.Spara.TabIndex = 12;
            this.Spara.Text = "Spara";
            this.Spara.UseVisualStyleBackColor = true;
            // 
            // Tillbaka
            // 
            this.Tillbaka.Location = new System.Drawing.Point(15, 292);
            this.Tillbaka.Name = "Tillbaka";
            this.Tillbaka.Size = new System.Drawing.Size(75, 23);
            this.Tillbaka.TabIndex = 13;
            this.Tillbaka.Text = "Tillbaka";
            this.Tillbaka.UseVisualStyleBackColor = true;
            // 
            // NyAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 330);
            this.Controls.Add(this.Tillbaka);
            this.Controls.Add(this.Spara);
            this.Controls.Add(this.BeskrivningLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Platstxt);
            this.Controls.Add(this.PlatsLabel);
            this.Controls.Add(this.SlutDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.AntalPlatserLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "NyAktivitet";
            this.Text = "Ny aktivitet";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label TitelLabel;
        private System.Windows.Forms.TextBox TitelTxt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label AntalPlatserLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label SlutDateLabel;
        private System.Windows.Forms.Label PlatsLabel;
        private System.Windows.Forms.TextBox Platstxt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label BeskrivningLabel;
        private System.Windows.Forms.Button Spara;
        private System.Windows.Forms.Button Tillbaka;
    }
}