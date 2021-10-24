
using System;
using System.Windows.Forms;

namespace Nfz_poczekalnia
{
    partial class dataB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.textBoxNazwaBadania = new System.Windows.Forms.TextBox();
            this.nazwaBadania = new System.Windows.Forms.Label();
            this.dataBadania = new System.Windows.Forms.Label();
            this.wybierzDate = new System.Windows.Forms.DateTimePicker();
            this.czasomierz1 = new System.Windows.Forms.Timer(this.components);
            this.aktualnaData = new System.Windows.Forms.Label();
            this.wybierzCzas = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(2, 95);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 0;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(36, 55);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(30, 15);
            this.Imie.TabIndex = 1;
            this.Imie.Text = "imie";
            this.Imie.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNazwaBadania
            // 
            this.textBoxNazwaBadania.Location = new System.Drawing.Point(129, 95);
            this.textBoxNazwaBadania.Name = "textBoxNazwaBadania";
            this.textBoxNazwaBadania.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwaBadania.TabIndex = 2;
            // 
            // nazwaBadania
            // 
            this.nazwaBadania.AutoSize = true;
            this.nazwaBadania.Location = new System.Drawing.Point(129, 55);
            this.nazwaBadania.Name = "nazwaBadania";
            this.nazwaBadania.Size = new System.Drawing.Size(87, 15);
            this.nazwaBadania.TabIndex = 3;
            this.nazwaBadania.Text = "Nazwa Badania";
            // 
            // dataBadania
            // 
            this.dataBadania.AutoSize = true;
            this.dataBadania.Location = new System.Drawing.Point(252, 55);
            this.dataBadania.Name = "dataBadania";
            this.dataBadania.Size = new System.Drawing.Size(76, 15);
            this.dataBadania.TabIndex = 4;
            this.dataBadania.Text = "Data Badania";
            // 
            // wybierzDate
            // 
            this.wybierzDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.wybierzDate.Location = new System.Drawing.Point(252, 95);
            this.wybierzDate.Name = "wybierzDate";
            this.wybierzDate.Size = new System.Drawing.Size(127, 23);
            this.wybierzDate.TabIndex = 5;
            // 
            // czasomierz1
            // 
            this.czasomierz1.Enabled = true;
            this.czasomierz1.Tick += new System.EventHandler(this.czasomierz1_Tick);
            // 
            // aktualnaData
            // 
            this.aktualnaData.Location = new System.Drawing.Point(55, 9);
            this.aktualnaData.Name = "aktualnaData";
            this.aktualnaData.Size = new System.Drawing.Size(113, 36);
            this.aktualnaData.TabIndex = 6;
            this.aktualnaData.Text = "data";
            // 
            // wybierzCzas
            // 
            this.wybierzCzas.Location = new System.Drawing.Point(237, 9);
            this.wybierzCzas.Name = "wybierzCzas";
            this.wybierzCzas.Size = new System.Drawing.Size(105, 36);
            this.wybierzCzas.TabIndex = 7;
            this.wybierzCzas.Text = "godzina co 10sec";
            this.wybierzCzas.Click += new System.EventHandler(this.wybierzCzas_Click);
            // 
            // MyTimer
            // 
            this.MyTimer.Enabled = true;
            this.MyTimer.Interval = 10000;
            this.MyTimer.Tick += new System.EventHandler(this.czasCo10SEK_Tick);
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Tabela.Location = new System.Drawing.Point(403, -2);
            this.Tabela.Name = "Tabela";
            this.Tabela.RowHeadersVisible = false;
            this.Tabela.RowTemplate.Height = 25;
            this.Tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabela.Size = new System.Drawing.Size(331, 430);
            this.Tabela.TabIndex = 8;
            this.Tabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwa Badania";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Badania";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(2, 145);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(377, 29);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "DODAJ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(2, 180);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(377, 34);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "USUN";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 430);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.wybierzCzas);
            this.Controls.Add(this.aktualnaData);
            this.Controls.Add(this.wybierzDate);
            this.Controls.Add(this.dataBadania);
            this.Controls.Add(this.nazwaBadania);
            this.Controls.Add(this.textBoxNazwaBadania);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.textBoxImie);
            this.Name = "dataB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private EventHandler czasCo10SEK()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.TextBox textBoxNazwaBadania;
        private System.Windows.Forms.Label nazwaBadania;
        private System.Windows.Forms.Label dataBadania;
        private System.Windows.Forms.DateTimePicker wybierzDate;
        public System.Windows.Forms.Timer czasomierz1;
        private System.Windows.Forms.Label aktualnaData;
        private System.Windows.Forms.Label wybierzCzas;
        private Timer MyTimer;
        private DataGridView Tabela;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button buttonAdd;
        private Button buttonDelete;
        //public System.Windows.Forms.Timer czasCo10SEK;
    }
}

