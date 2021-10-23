
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nazwaBadania = new System.Windows.Forms.Label();
            this.dataBadania = new System.Windows.Forms.Label();
            this.wybierzDate = new System.Windows.Forms.DateTimePicker();
            this.czasomierz1 = new System.Windows.Forms.Timer(this.components);
            this.aktualnaData = new System.Windows.Forms.Label();
            this.wybierzCzas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(78, 42);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(30, 15);
            this.Imie.TabIndex = 1;
            this.Imie.Text = "imie";
            this.Imie.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // nazwaBadania
            // 
            this.nazwaBadania.AutoSize = true;
            this.nazwaBadania.Location = new System.Drawing.Point(78, 77);
            this.nazwaBadania.Name = "nazwaBadania";
            this.nazwaBadania.Size = new System.Drawing.Size(87, 15);
            this.nazwaBadania.TabIndex = 3;
            this.nazwaBadania.Text = "Nazwa Badania";
            // 
            // dataBadania
            // 
            this.dataBadania.AutoSize = true;
            this.dataBadania.Location = new System.Drawing.Point(78, 115);
            this.dataBadania.Name = "dataBadania";
            this.dataBadania.Size = new System.Drawing.Size(76, 15);
            this.dataBadania.TabIndex = 4;
            this.dataBadania.Text = "Data Badania";
            // 
            // wybierzDate
            // 
            this.wybierzDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.wybierzDate.Location = new System.Drawing.Point(177, 107);
            this.wybierzDate.Name = "wybierzDate";
            this.wybierzDate.Size = new System.Drawing.Size(200, 23);
            this.wybierzDate.TabIndex = 5;
            // 
            // czasomierz1
            // 
            this.czasomierz1.Enabled = true;
            this.czasomierz1.Tick += new System.EventHandler(this.czasomierz1_Tick);
            // 
            // aktualnaData
            // 
            this.aktualnaData.AutoSize = true;
            this.aktualnaData.Location = new System.Drawing.Point(248, 13);
            this.aktualnaData.Name = "aktualnaData";
            this.aktualnaData.Size = new System.Drawing.Size(38, 15);
            this.aktualnaData.TabIndex = 6;
            this.aktualnaData.Text = "label1";
            // 
            // wybierzCzas
            // 
            this.wybierzCzas.AutoSize = true;
            this.wybierzCzas.Location = new System.Drawing.Point(330, 13);
            this.wybierzCzas.Name = "wybierzCzas";
            this.wybierzCzas.Size = new System.Drawing.Size(38, 15);
            this.wybierzCzas.TabIndex = 7;
            this.wybierzCzas.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "newBadLine";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dataB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wybierzCzas);
            this.Controls.Add(this.aktualnaData);
            this.Controls.Add(this.wybierzDate);
            this.Controls.Add(this.dataBadania);
            this.Controls.Add(this.nazwaBadania);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.textBox1);
            this.Name = "dataB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nazwaBadania;
        private System.Windows.Forms.Label dataBadania;
        private System.Windows.Forms.DateTimePicker wybierzDate;
        public System.Windows.Forms.Timer czasomierz1;
        private System.Windows.Forms.Label aktualnaData;
        private System.Windows.Forms.Label wybierzCzas;
        private System.Windows.Forms.Label label1;
    }
}

