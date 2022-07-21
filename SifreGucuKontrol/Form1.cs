using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreGucuKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre= txtSifre.Text.ToLower();
            
            if (sifre.Length<6)
            {
                lblSifre.Text = "weak";
                lblSifre.ForeColor = Color.Red;
                progressBar1.Value = 20;
                progressBar1.ForeColor = Color.Red;
            }
            else
            {
                if (sifre.All(char.IsLetter) || sifre.All(char.IsDigit) || !sifre.Any(char.IsLetterOrDigit))
                {
                    lblSifre.Text = "weak";
                    lblSifre.ForeColor = Color.Red;
                    progressBar1.Value = 30;
                    progressBar1.ForeColor = Color.Red;

                }
                else if (sifre.Any(char.IsLetter) && sifre.Any(char.IsDigit) && !sifre.All(char.IsLetterOrDigit))
                {
                    lblSifre.Text = "strong";
                    lblSifre.ForeColor = Color.Green;
                    progressBar1.Value = 100;
                    progressBar1.ForeColor = Color.Green;
                }
                else
                {
                    lblSifre.Text = "medium";
                    lblSifre.ForeColor = Color.Blue;
                    progressBar1.Value = 50;
                    progressBar1.ForeColor=Color.Blue;
                }
            }          
        }
    }
}
