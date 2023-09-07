using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWinFromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private int penambahan (int a , int b)
        {
            return a + b ;
        }

        private int pengurangan (int a, int b)
        {
            return a - b ;
        }

        private int perkalian (int a, int b)
        {
            return a * b ;
        }

        private int pembagian (int a, int b)
        {
            return a / b ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse (txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            lstHasil.Items.Clear();

            if (cbOperator.Text == "Penambahan")
            {
                lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, penambahan(a, b)));
            }
            else if (cbOperator.Text == "Pengurangan")
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b)));
            }
            else if (cbOperator.Text == "Perkalian")
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} x {1} = {2}", a, b, perkalian(a, b)));
            }
            else if (cbOperator.Text == "Pembagian")
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} / {1} = {2}", a, b, pembagian(a, b)));
            }
        }
    }
}
