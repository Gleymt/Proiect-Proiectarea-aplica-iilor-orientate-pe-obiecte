namespace PAOO2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.adaugaClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paooDataSet = new PAOO2.paooDataSet();
            this.clientiTableAdapter = new PAOO2.paooDataSetTableAdapters.clientiTableAdapter();
            this.stergeClient = new System.Windows.Forms.Button();
            this.ActualizareClienti = new System.Windows.Forms.Button();
            this.adaugaTranzactie = new System.Windows.Forms.Button();
            this.stergeTranzactie = new System.Windows.Forms.Button();
            this.actualizeazaTranz = new System.Windows.Forms.Button();
            this.idtranz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaprim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatranz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delogare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenumeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cautarenumecli = new System.Windows.Forms.TextBox();
            this.cautare = new System.Windows.Forms.Button();
            this.cautareidcl = new System.Windows.Forms.TextBox();
            this.cautareid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paooDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaClient
            // 
            this.adaugaClient.BackColor = System.Drawing.Color.OldLace;
            this.adaugaClient.Location = new System.Drawing.Point(41, 68);
            this.adaugaClient.Name = "adaugaClient";
            this.adaugaClient.Size = new System.Drawing.Size(143, 36);
            this.adaugaClient.TabIndex = 0;
            this.adaugaClient.Text = "Adaugare Client";
            this.adaugaClient.UseVisualStyleBackColor = false;
            this.adaugaClient.Click += new System.EventHandler(this.adaugaClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClient,
            this.NumeClient,
            this.PrenumeClient,
            this.CNPclient,
            this.SerieClient});
            this.dataGridView1.Location = new System.Drawing.Point(226, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 194);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtranz,
            this.IDcli,
            this.sumaprim,
            this.sumaof,
            this.datatranz});
            this.dataGridView2.Location = new System.Drawing.Point(226, 294);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(769, 194);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "clienti";
            this.clientiBindingSource.DataSource = this.paooDataSet;
            // 
            // paooDataSet
            // 
            this.paooDataSet.DataSetName = "paooDataSet";
            this.paooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // stergeClient
            // 
            this.stergeClient.BackColor = System.Drawing.Color.OldLace;
            this.stergeClient.Location = new System.Drawing.Point(41, 123);
            this.stergeClient.Name = "stergeClient";
            this.stergeClient.Size = new System.Drawing.Size(143, 36);
            this.stergeClient.TabIndex = 3;
            this.stergeClient.Text = "Stergere Client";
            this.stergeClient.UseVisualStyleBackColor = false;
            this.stergeClient.Click += new System.EventHandler(this.stergeClient_Click);
            // 
            // ActualizareClienti
            // 
            this.ActualizareClienti.BackColor = System.Drawing.Color.OldLace;
            this.ActualizareClienti.Location = new System.Drawing.Point(41, 179);
            this.ActualizareClienti.Name = "ActualizareClienti";
            this.ActualizareClienti.Size = new System.Drawing.Size(143, 36);
            this.ActualizareClienti.TabIndex = 4;
            this.ActualizareClienti.Text = "Actualizeaza";
            this.ActualizareClienti.UseVisualStyleBackColor = false;
            this.ActualizareClienti.Click += new System.EventHandler(this.ActualizareClienti_Click);
            // 
            // adaugaTranzactie
            // 
            this.adaugaTranzactie.BackColor = System.Drawing.Color.OldLace;
            this.adaugaTranzactie.Location = new System.Drawing.Point(41, 294);
            this.adaugaTranzactie.Name = "adaugaTranzactie";
            this.adaugaTranzactie.Size = new System.Drawing.Size(143, 36);
            this.adaugaTranzactie.TabIndex = 5;
            this.adaugaTranzactie.Text = "Adaugare Tranzactie";
            this.adaugaTranzactie.UseVisualStyleBackColor = false;
            this.adaugaTranzactie.Click += new System.EventHandler(this.adaugaTranzactie_Click);
            // 
            // stergeTranzactie
            // 
            this.stergeTranzactie.BackColor = System.Drawing.Color.OldLace;
            this.stergeTranzactie.Location = new System.Drawing.Point(41, 350);
            this.stergeTranzactie.Name = "stergeTranzactie";
            this.stergeTranzactie.Size = new System.Drawing.Size(143, 36);
            this.stergeTranzactie.TabIndex = 6;
            this.stergeTranzactie.Text = "Stergere Tranzactie";
            this.stergeTranzactie.UseVisualStyleBackColor = false;
            this.stergeTranzactie.Click += new System.EventHandler(this.stergeTranzactie_Click);
            // 
            // actualizeazaTranz
            // 
            this.actualizeazaTranz.BackColor = System.Drawing.Color.OldLace;
            this.actualizeazaTranz.Location = new System.Drawing.Point(41, 405);
            this.actualizeazaTranz.Name = "actualizeazaTranz";
            this.actualizeazaTranz.Size = new System.Drawing.Size(143, 36);
            this.actualizeazaTranz.TabIndex = 7;
            this.actualizeazaTranz.Text = "Actualizeaza";
            this.actualizeazaTranz.UseVisualStyleBackColor = false;
            this.actualizeazaTranz.Click += new System.EventHandler(this.actualizeazaTranz_Click);
            // 
            // idtranz
            // 
            this.idtranz.DataPropertyName = "idtranz";
            this.idtranz.HeaderText = "IDTranzactie";
            this.idtranz.Name = "idtranz";
            this.idtranz.Visible = false;
            // 
            // IDcli
            // 
            this.IDcli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDcli.DataPropertyName = "idclient";
            this.IDcli.HeaderText = "ID Client";
            this.IDcli.Name = "IDcli";
            // 
            // sumaprim
            // 
            this.sumaprim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumaprim.DataPropertyName = "sumaprimita";
            this.sumaprim.HeaderText = "Suma Primita";
            this.sumaprim.Name = "sumaprim";
            // 
            // sumaof
            // 
            this.sumaof.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumaof.DataPropertyName = "sumaoferita";
            this.sumaof.HeaderText = "Suma Oferita";
            this.sumaof.Name = "sumaof";
            // 
            // datatranz
            // 
            this.datatranz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datatranz.DataPropertyName = "datatranzactiei";
            this.datatranz.HeaderText = "Data Tranzactiei";
            this.datatranz.Name = "datatranz";
            this.datatranz.ReadOnly = true;
            // 
            // Delogare
            // 
            this.Delogare.BackColor = System.Drawing.Color.OldLace;
            this.Delogare.Location = new System.Drawing.Point(12, 483);
            this.Delogare.Name = "Delogare";
            this.Delogare.Size = new System.Drawing.Size(75, 23);
            this.Delogare.TabIndex = 8;
            this.Delogare.Text = "Delogare";
            this.Delogare.UseVisualStyleBackColor = false;
            this.Delogare.Click += new System.EventHandler(this.Delogare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Casa de schimb valutar EZXchange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Clienti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tranzactii";
            // 
            // IdClient
            // 
            this.IdClient.DataPropertyName = "idclient";
            this.IdClient.HeaderText = "ID";
            this.IdClient.Name = "IdClient";
            // 
            // NumeClient
            // 
            this.NumeClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumeClient.DataPropertyName = "nume_cli";
            this.NumeClient.HeaderText = "Nume Client";
            this.NumeClient.Name = "NumeClient";
            // 
            // PrenumeClient
            // 
            this.PrenumeClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrenumeClient.DataPropertyName = "prenume_cli";
            this.PrenumeClient.HeaderText = "Prenume Client";
            this.PrenumeClient.Name = "PrenumeClient";
            // 
            // CNPclient
            // 
            this.CNPclient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNPclient.DataPropertyName = "cnp_cli";
            this.CNPclient.HeaderText = "CNP";
            this.CNPclient.Name = "CNPclient";
            // 
            // SerieClient
            // 
            this.SerieClient.DataPropertyName = "serie_cli";
            this.SerieClient.HeaderText = "Serie Buletin";
            this.SerieClient.Name = "SerieClient";
            // 
            // cautarenumecli
            // 
            this.cautarenumecli.Location = new System.Drawing.Point(799, 45);
            this.cautarenumecli.Name = "cautarenumecli";
            this.cautarenumecli.Size = new System.Drawing.Size(100, 20);
            this.cautarenumecli.TabIndex = 12;
            // 
            // cautare
            // 
            this.cautare.Location = new System.Drawing.Point(905, 43);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(75, 23);
            this.cautare.TabIndex = 13;
            this.cautare.Text = "Cautare";
            this.cautare.UseVisualStyleBackColor = true;
            this.cautare.Click += new System.EventHandler(this.cautare_Click);
            // 
            // cautareidcl
            // 
            this.cautareidcl.Location = new System.Drawing.Point(799, 272);
            this.cautareidcl.Name = "cautareidcl";
            this.cautareidcl.Size = new System.Drawing.Size(100, 20);
            this.cautareidcl.TabIndex = 14;
            // 
            // cautareid
            // 
            this.cautareid.Location = new System.Drawing.Point(905, 270);
            this.cautareid.Name = "cautareid";
            this.cautareid.Size = new System.Drawing.Size(75, 23);
            this.cautareid.TabIndex = 15;
            this.cautareid.Text = "Cautare";
            this.cautareid.UseVisualStyleBackColor = true;
            this.cautareid.Click += new System.EventHandler(this.cautareidcli_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 518);
            this.Controls.Add(this.cautareid);
            this.Controls.Add(this.cautareidcl);
            this.Controls.Add(this.cautare);
            this.Controls.Add(this.cautarenumecli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delogare);
            this.Controls.Add(this.actualizeazaTranz);
            this.Controls.Add(this.stergeTranzactie);
            this.Controls.Add(this.adaugaTranzactie);
            this.Controls.Add(this.ActualizareClienti);
            this.Controls.Add(this.stergeClient);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adaugaClient);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paooDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private paooDataSet paooDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private paooDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
        private System.Windows.Forms.Button stergeClient;
        private System.Windows.Forms.Button ActualizareClienti;
        private System.Windows.Forms.Button adaugaTranzactie;
        private System.Windows.Forms.Button stergeTranzactie;
        private System.Windows.Forms.Button actualizeazaTranz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtranz;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaprim;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaof;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatranz;
        private System.Windows.Forms.Button Delogare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenumeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieClient;
        private System.Windows.Forms.TextBox cautarenumecli;
        private System.Windows.Forms.Button cautare;
        private System.Windows.Forms.TextBox cautareidcl;
        private System.Windows.Forms.Button cautareid;
    }
}