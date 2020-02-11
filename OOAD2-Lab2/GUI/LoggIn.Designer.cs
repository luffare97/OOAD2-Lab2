namespace GUI
{
    partial class LoggIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbLösen = new System.Windows.Forms.TextBox();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användar ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lösenord:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(88, 6);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(145, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbLösen
            // 
            this.tbLösen.Location = new System.Drawing.Point(88, 40);
            this.tbLösen.Name = "tbLösen";
            this.tbLösen.PasswordChar = '*';
            this.tbLösen.Size = new System.Drawing.Size(145, 20);
            this.tbLösen.TabIndex = 3;
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(158, 66);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoggaIn.TabIndex = 4;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // LoggIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 103);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.tbLösen);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoggIn";
            this.Text = "Logga in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbLösen;
        private System.Windows.Forms.Button btnLoggaIn;
    }
}

