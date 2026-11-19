using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4._4
{
    public partial class Form1 : Form
    {
        int sualIndex = 0;
        int bal = 0;
        string[] suallar =
{
            "Azərbaycanın paytaxtı hansıdır?",
            "Dünyanın ən böyük okeanı hansıdır?",
            "1 + 1 neçə edir?",
            "Azərbaycan dövlət müstəqillik günü nə vaxtdır?",
            "Azərbaycanın milli valyutası hansıdır?"
};

        string[,] cavablar =
        {
            { "Bakı", "Gəncə", "Şəki", "Quba" },
            { "Atlantik", "Hind", "Sakit", "Şimal Buzlu" },
            { "1", "2", "3", "4" },
            { "28 may", "9 noyabr", "31 mart", "31 dekabr" },
            { "Dollar", "Avro", "Manat", "Lirə" }
        };

        int[] duzgunCavablar = { 0, 2, 1, 0, 2 };

        public Form1()
        {
            InitializeComponent();
            
        }

        void SualiGoster()
        {
            lblSual.Text = suallar[sualIndex];
            grpSual.Text = "Sual " + (sualIndex + 1);

            rbA.Text = "A) " + cavablar[sualIndex, 0];
            rbB.Text = "B) " + cavablar[sualIndex, 1];
            rbC.Text = "C) " + cavablar[sualIndex, 2];
            rbD.Text = "D) " + cavablar[sualIndex, 3];

            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            progressBar1.Value = sualIndex + 1;
        }
        private void btnNovbeti_Click(object sender, EventArgs e)
        {
            int secim = -1;

            if (rbA.Checked)
                secim = 0;
            else if (rbB.Checked)
                secim = 1;
            else if (rbC.Checked)
                secim = 2;
            else if (rbD.Checked)
                secim = 3;

            if (secim == -1)
            {
                MessageBox.Show("Zəhmət olmasa, bir cavab seçin!");
                return;
            }

            if (secim == duzgunCavablar[sualIndex])
            {
                bal++;
            }

            sualIndex++;

            if (sualIndex < 5)
            {
                SualiGoster();
            }
            else
            {
                progressBar1.Value = 5;

                DialogResult netice = MessageBox.Show(
                    "Test bitdi!\nTopladığınız bal: " + bal + " / 5\nYenidən başlamaq istəyirsiniz?",
                    "Nəticə",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (netice == DialogResult.Yes)
                {
                    sualIndex = 0;
                    bal = 0;
                    SualiGoster();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void grbSual_Enter(object sender, EventArgs e)
        {

        }
    }
}
