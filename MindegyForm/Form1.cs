using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MindegyForm
{
    public partial class Form1 : Form
    {
        static List<int> szamok = new List<int>();

        static double osszege;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("adatok.txt");

            while (!file.EndOfStream)
            {
                try
                {
                    szamok.Add(int.Parse(file.ReadLine()));
                }
                catch (Exception ex)
                {
                    
                }
                
            }

            file.Close();
        }

        private void btnOsszeg_Click(object sender, EventArgs e)
        {
            int osszeg = 0;

            foreach (var sz in szamok)
            {
                osszeg += sz;
            }
            
            lbEredmeny.Items.Add("A listában szereplő számok összege: ");
            lbEredmeny.Items.Add(osszeg);

            osszege = osszeg;

        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Clear();
        }

        private void btnAtlag_Click(object sender, EventArgs e)
        {
            double atlag = osszege / szamok.Count();
            lbEredmeny.Items.Add("\nA listában szereplő számok átlaga: ");
            lbEredmeny.Items.Add(atlag);
        }

        private void btnHanyadik_Click(object sender, EventArgs e)
        {

            lbEredmeny.Items.Add("\n7143 előfurdulásának helye a listában: ");

            int j = 0;
            while (j < szamok.Count && j != 7143)
            {
                j++;
            }
            if (j<=szamok.Count)
            {
                lbEredmeny.Items.Add("Nincs 7143 a listában");
            }
            else
            {
                lbEredmeny.Items.Add(j);
            }
        }

        private void btnHanyszor_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Add("\n1170 előfordulása: ");
            int db = 0;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (i==1170)
                {
                    db++;
                }
            }
            lbEredmeny.Items.Add(db);
        }

        private void btnVane_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Add("Van-e 8876 a lstában?");
            int j = 0;
            while (j<szamok.Count && j!=8876)
            {
                j++;
            }

            if (j<szamok.Count || szamok[szamok.Count-1] == 8876)
            {
                lbEredmeny.Items.Add("Van 8876 a listában");
            }
            else
            {
                lbEredmeny.Items.Add("Nincs 8876 a listában");
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Add("\nLista legkisebb értéke");
            lbEredmeny.Items.Add(szamok.Min());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lbEredmeny.Items.Add("\nLista legnagyobb értéke");
            lbEredmeny.Items.Add(szamok.Max());
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
