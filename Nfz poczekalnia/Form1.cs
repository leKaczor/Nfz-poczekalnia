using System;
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
        //policja

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }   
}
