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

        private void czasCo10SEK_Tick(object sender, EventArgs e)
        {
            wybierzCzas.Text = DateTime.Now.ToString("HH:mm");

        }
        class que
        {
            private int n;
            private int qptr;
            private int qcnt;
            private string[] Q;

            public que(int a)
            {
                n = a;
                Q = new string[a];
                qptr = qcnt = 0;
            }
            ~que()
            {
                GC.Collect();
                GC.SuppressFinalize(Q);
                GC.SuppressFinalize(this);
            }
            public void usun()
            {
                if (qcnt != 0)
                {
                    qcnt--;
                    qptr++;
                    if (qptr == n) qptr = 0;
                }

            }
            public string front()
            {
                if (qcnt != 0) return Q[qptr];
                return "";
            }
            public void push(string v)
            {
                int i;
                if (qcnt < n)
                {
                    i = qptr + qcnt++;
                    if (i >= n) i -= n;
                    Q[i] = v;
                }
            }
            public bool empty()
            {
                return qcnt != 0;
            }
        }
    }   
}
