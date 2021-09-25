namespace PAOO2
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTranz = new System.Windows.Forms.TextBox();
            this.idCli = new System.Windows.Forms.TextBox();
            this.sumaPrim = new System.Windows.Forms.TextBox();
            this.sumaOf = new System.Windows.Forms.TextBox();
            this.adaugaTranz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTranz = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tranzactie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suma primita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma oferita";
            // 
            // idTranz
            // 
            this.idTranz.Location = new System.Drawing.Point(147, 27);
            this.idTranz.Name = "idTranz";
            this.idTranz.Size = new System.Drawing.Size(200, 20);
            this.idTranz.TabIndex = 5;
            // 
            // idCli
            // 
            this.idCli.Location = new System.Drawing.Point(147, 61);
            this.idCli.Name = "idCli";
            this.idCli.Size = new System.Drawing.Size(200, 20);
            this.idCli.TabIndex = 6;
            // 
            // sumaPrim
            // 
            this.sumaPrim.Location = new System.Drawing.Point(147, 97);
            this.sumaPrim.Name = "sumaPrim";
            this.sumaPrim.Size = new System.Drawing.Size(200, 20);
            this.sumaPrim.TabIndex = 7;
            // 
            // sumaOf
            // 
            this.sumaOf.Location = new System.Drawing.Point(147, 130);
            this.sumaOf.Name = "sumaOf";
            this.sumaOf.Size = new System.Drawing.Size(200, 20);
            this.sumaOf.TabIndex = 8;
            // 
            // adaugaTranz
            // 
            this.adaugaTranz.BackColor = System.Drawing.Color.OldLace;
            this.adaugaTranz.Location = new System.Drawing.Point(91, 199);
            this.adaugaTranz.Name = "adaugaTranz";
            this.adaugaTranz.Size = new System.Drawing.Size(75, 23);
            this.adaugaTranz.TabIndex = 9;
            this.adaugaTranz.Text = "Adauga";
            this.adaugaTranz.UseVisualStyleBackColor = false;
            this.adaugaTranz.Click += new System.EventHandler(this.adaugaTranz_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(203, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Tranzactiei";
            // 
            // dataTranz
            // 
            this.dataTranz.Location = new System.Drawing.Point(147, 160);
            this.dataTranz.Name = "dataTranz";
            this.dataTranz.Size = new System.Drawing.Size(200, 20);
            this.dataTranz.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(386, 244);
            this.Controls.Add(this.dataTranz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adaugaTranz);
            this.Controls.Add(this.sumaOf);
            this.Controls.Add(this.sumaPrim);
            this.Controls.Add(this.idCli);
            this.Controls.Add(this.idTranz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTranz;
        private System.Windows.Forms.TextBox idCli;
        private System.Windows.Forms.TextBox sumaPrim;
        private System.Windows.Forms.TextBox sumaOf;
        private System.Windows.Forms.Button adaugaTranz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataTranz;
    }
}