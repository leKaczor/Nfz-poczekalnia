﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nfz_poczekalnia
{
    public partial class dataB : Form
    {
        public dataB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void czasomierz1_Tick(object sender, EventArgs e)
        {

            aktualnaData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void czasCo10SEK_Tick(object sender, EventArgs e)
        {
            wybierzCzas.Text = DateTime.Now.ToString("HH:mm");

        }

        private void wybierzCzas_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int d = Tabela.Rows.Add();
            Tabela.Rows[d].Cells[0].Value = textBoxImie.Text;
            Tabela.Rows[d].Cells[1].Value = textBoxNazwaBadania.Text;
            Tabela.Rows[d].Cells[2].Value = wybierzDate.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int u = Tabela.CurrentCell.RowIndex;
            Tabela.Rows.RemoveAt(u);
        }
    }
}
