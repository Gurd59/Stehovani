using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stěhování
{
    public partial class Form1 : Form
    {
        string[] najemnici = new string[11];
        int cislobytu;
        double[] najem = new double[11];


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nastehovat_Click(object sender, EventArgs e)
        {
            cislobytu = Convert.ToInt32(nmr_cislo.Value);
            if (najemnici[cislobytu] == null)
            {

                cislobytu = Convert.ToInt32(nmr_cislo.Value);
                najemnici[cislobytu] = txt_rodina.Text;
                string zprava = najemnici[cislobytu] + " - " + " je/jsou nastěhován/ni do bytu č." + cislobytu.ToString();
                MessageBox.Show(zprava);
            }
            else
            {
                string zprava = "?";
                MessageBox.Show(zprava);
            }


        }

        private void btn_vystehovat_Click(object sender, EventArgs e)
        {
            cislobytu = Convert.ToInt32(nmr_cislo.Value);
            if (najemnici[cislobytu] != null)
            {
                cislobytu = Convert.ToInt32(nmr_cislo.Value);

              string zprava = najemnici[cislobytu] + " - " + " je/jsou vystěhován/ni do bytu č." + cislobytu.ToString();
             MessageBox.Show(zprava);             
                najemnici[cislobytu] = null;
            }
            else
            {
                string zprava = "kys";
                MessageBox.Show(zprava);
            }
        }

        private void btn_zobrazit_Click(object sender, EventArgs e)
        {
            cislobytu = Convert.ToInt32(nmr_cislo.Value);
            string zprava = "";
            zprava += cislobytu + ": " + najemnici[cislobytu];
            MessageBox.Show(zprava);

        }

        private void btn_vse_Click(object sender, EventArgs e)
        {

            string zprava = "";
            for(int i = 0; i < najemnici.Length; i++)
            {
                zprava += i.ToString() + ": " + najemnici[i] + Environment.NewLine;
            }
            MessageBox.Show(zprava);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            najemnici[1] = "jmeno1";
            najemnici[3] = "jmeno2"; 
            najemnici[6] = "jmeno3";
            najemnici[10] = "jmeno4";
            najem[0] = 0;
            najem[1] = 1000;
            najem[2] = 2000;
            najem[3] = 3000;
            najem[4] = 4000;
            najem[5] = 5000;
            najem[6] = 6000;
            najem[7] = 7000;
            najem[8] = 8000;
            najem[9] = 9000;
            najem[10] = 10000;
        }

        private void btn_nájem_Click(object sender, EventArgs e)
        {
            cislobytu = Convert.ToInt32(nmr_cislo.Value);
            double money = Convert.ToDouble(nmr_najem.Value);
            najem[cislobytu] = money;
            string zprava = "";
            zprava += "Nájem pro byt " + cislobytu + " byl změněn na " + money + "kč" ;
            MessageBox.Show(zprava);
        }

        private void btn_zobrazrodinu_Click(object sender, EventArgs e)
        {

            string zprava = "";
            for (int i = 0; i < najemnici.Length; i++)
            {
                zprava += i.ToString() + ": " + najemnici[i] + " " + " - " + najem[i] + "kč" + Environment.NewLine;
            }
            MessageBox.Show(zprava);

        }
    }
}
